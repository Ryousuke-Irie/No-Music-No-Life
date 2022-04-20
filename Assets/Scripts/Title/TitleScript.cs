
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//追加
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScript : MonoBehaviour
{
    float fadeSpeed = 0.2f;              //フェードの変わる速度
    float red, green, blue, alfa;　　　　　//フェードの色と透明度

    public bool isFadeOut = false;      //フェードアウトの処理の開始、完了を管理するフラグ

    Image fadeImage;

    // Start is called before the first frame update
    void Start()
    {
        //  フェードの処理
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("return"))    //|| Input.GetButtonDown("Action1")
        {
            if (isFadeOut==true)
            {
                StartFadeOut();
            }
            
            //時間をずらす
            Invoke("LoadScene", 2f);
        }
        
    }
    void LoadScene()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
    void StartFadeOut()
    {
        fadeImage.enabled = true;  // a)パネルの表示をオンにする
        alfa += fadeSpeed;         // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        
            if (alfa >= 1)
            {             // d)完全に不透明になったら処理を抜ける
                isFadeOut = false;
            }
        
    }
    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }

}