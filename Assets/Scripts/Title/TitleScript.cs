
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�ǉ�
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScript : MonoBehaviour
{
    float fadeSpeed = 0.2f;              //�t�F�[�h�̕ς�鑬�x
    float red, green, blue, alfa;�@�@�@�@�@//�t�F�[�h�̐F�Ɠ����x

    public bool isFadeOut = false;      //�t�F�[�h�A�E�g�̏����̊J�n�A�������Ǘ�����t���O

    Image fadeImage;

    // Start is called before the first frame update
    void Start()
    {
        //  �t�F�[�h�̏���
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
            
            //���Ԃ����炷
            Invoke("LoadScene", 2f);
        }
        
    }
    void LoadScene()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
    void StartFadeOut()
    {
        fadeImage.enabled = true;  // a)�p�l���̕\�����I���ɂ���
        alfa += fadeSpeed;         // b)�s�����x�����X�ɂ�����
        SetAlpha();               // c)�ύX���������x���p�l���ɔ��f����
        
            if (alfa >= 1)
            {             // d)���S�ɕs�����ɂȂ����珈���𔲂���
                isFadeOut = false;
            }
        
    }
    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }

}