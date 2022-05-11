using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ResultScript : MonoBehaviour
{
    private GameObject refObj;
    private GameObject refObj2;
    private GameObject result;
    private GameObject cloneResult;

    private float initialPos = 20.0f;
    private float move = 10.0f;

    private bool moveEndFlag = false;
    private bool scoreEndFlag = false;
    private bool rankEndFlag = false;

    private float PosY = 10.0f;
    private float PosX = 10.0f;

    private float Between = 5.0f;

    private int plusScore = 10;
    private int tempScore = 0;

    private GameObject Zero;
    private GameObject One;
    private GameObject Two;
    private GameObject Three;
    private GameObject Four;
    private GameObject Five;
    private GameObject Six;
    private GameObject Seven;
    private GameObject Eight;
    private GameObject Nine;

    [System.NonSerialized] public bool deleteFlag = true;

    private GameObject fadeObj;

    private bool oneTimeFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        refObj2 = GameObject.Find("Main Camera");
        result = (GameObject)Resources.Load("Result");

        fadeObj = GameObject.Find("fade_white2");

        //Zero = (GameObject)Resources.Load("Numeral/Zero2");
        //One = (GameObject)Resources.Load("Numeral/One2");
        //Two = (GameObject)Resources.Load("Numeral/Two2");
        //Three = (GameObject)Resources.Load("Numeral/Three2");
        //Four = (GameObject)Resources.Load("Numeral/Four2");
        //Five = (GameObject)Resources.Load("Numeral/Five2");
        //Six = (GameObject)Resources.Load("Numeral/Six2");
        //Seven = (GameObject)Resources.Load("Numeral/Seven2");
        //Eight = (GameObject)Resources.Load("Numeral/Eight2");
        //Nine = (GameObject)Resources.Load("Numeral/Nine2");
    }

    void FixedUpdate()
    {
        if (moveEndFlag)
        {
            // スコア表示
            SetScore();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (refObj.GetComponent<PlayerScript>().goalFlag)
        {
            // 背景表示
            SetBackGround();
        }

        if (scoreEndFlag)
        {
            // スコアランク表示
            SetRank();
        }

        if (rankEndFlag)
        {
            // ステージ選択画面へ戻る
            BackToStageSelectScene();
        }
    }

    private void SetBackGround()
    {
        if (!cloneResult)
        {
            cloneResult = Instantiate(result, new Vector3(refObj2.transform.position.x - initialPos, -0.8f, 0.0f), Quaternion.identity);
        }

        if (cloneResult.transform.position.x < refObj2.transform.position.x)
        {
            cloneResult.transform.position += new Vector3(move * Time.deltaTime, 0.0f, 0.0f);
        }
        else
        {
            moveEndFlag = true;
        }
    }

    private void SetScore()
    {
        //tempScore += plusScore;

        //// 桁数計算
        //int number = tempScore;

        //int digit = 0;

        //while (number > 0)
        //{
        //    number = number / 10;
        //    digit += 1;
        //}

        //if (digit == 0)
        //{
        //    digit = 1;
        //}

        //number = tempScore;

        //deleteFlag = false;

        //if (!scoreEndFlag = true)
        //{
        //    for (int i = 0; i < digit; i++)
        //    {
        //        // 今回表示する桁の数字
        //        int num = (int)(number % 10);

        //        if (num == 0)
        //        {
        //            GameObject cloneNum = Instantiate(Zero, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
        //        }

        //        if (num == 1)
        //        {
        //            GameObject cloneNum = Instantiate(One, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
        //        }

        //        if (num == 2)
        //        {
        //            GameObject cloneNum = Instantiate(Two, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
        //        }

        //        if (num == 3)
        //        {
        //            GameObject cloneNum = Instantiate(Three, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
        //        }

        //        if (num == 4)
        //        {
        //            GameObject cloneNum = Instantiate(Four, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
        //        }

        //        if (num == 5)
        //        {
        //            GameObject cloneNum = Instantiate(Five, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
        //        }

        //        if (num == 6)
        //        {
        //            GameObject cloneNum = Instantiate(Six, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
        //        }

        //        if (num == 7)
        //        {
        //            GameObject cloneNum = Instantiate(Seven, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
        //        }

        //        if (num == 8)
        //        {
        //            GameObject cloneNum = Instantiate(Eight, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
        //        }

        //        if (num == 9)
        //        {
        //            GameObject cloneNum = Instantiate(Nine, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
        //        }

        //        // 次の桁へ
        //        number /= 10;
        //    }
        //}

        //if (tempScore == refObj.GetComponent<PlayerScript>().score)
        //{
        //    scoreEndFlag = true;
        //}
        //else
        //{
        //    deleteFlag = true;
        //}

        // 仮設置
        scoreEndFlag = true;
    }

    private void SetRank()
    {
        // スコアランクを表示する

        rankEndFlag = true;
    }

    private void BackToStageSelectScene()
    {
        if (fadeObj)
        {
            if (!oneTimeFlag)
            {
                if (Gamepad.current == null)
                {
                    if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
                    {
                        fadeObj.transform.position = new Vector3(refObj2.transform.position.x, refObj2.transform.position.y, 0.0f);
                        fadeObj.GetComponent<FadeScript>().isFadeOut = true;
                        oneTimeFlag = true;
                    }
                }
                else
                {
                    if (Gamepad.current.buttonSouth.wasPressedThisFrame || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
                    {
                        fadeObj.transform.position = new Vector3(refObj2.transform.position.x, refObj2.transform.position.y, 0.0f);
                        fadeObj.GetComponent<FadeScript>().isFadeOut = true;
                        oneTimeFlag = true;
                    }
                }
            }

            if (fadeObj.GetComponent<FadeScript>().fadeEndFlag)
            {
                SceneManager.LoadScene("StageSelectScene");
            }
        }
    }
}
