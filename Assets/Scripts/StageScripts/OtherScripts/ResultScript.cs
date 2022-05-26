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
    private float move = 20.0f;

    private bool moveEndFlag = false;
    private bool scoreEndFlag = false;
    private bool rankEndFlag = false;

    private float PosY = -0.08f;
    private float PosX = 1.5f;

    private float Between = 1.8f;

    private int plusScore = 100;
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

    private GameObject cloneRank;
    public int Rank_C   = 5000;
    public int Rank_B   = 9000;
    public int Rank_A   = 13000;
    public int Rank_S   = 17000;
    public int Rank_SS  = 21000;
    public int Rank_SSS = 25000;

    private float PosYr = 5.05f;
    private float PosXr = 1.0f;

    private float MaxScale = 1.5f;
    private float ScaleAmount = 15.0f;

    [System.NonSerialized] public bool deleteFlag = true;

    private GameObject fadeObj;

    private bool oneTimeFlag = false;

    private GameObject refObjicon;
    private GameObject cloneObjIcon;

    private GameObject refObjMenu;
    private GameObject cloneMenu;

    private GameObject refKirakira;
    private GameObject cloneKirakira;

    private float PosKiX = 0.0f;
    private float PosKiY = 5.05f;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        refObj2 = GameObject.Find("Main Camera");
        result = (GameObject)Resources.Load("Result");

        refObjMenu = (GameObject)Resources.Load("UIResult");

        fadeObj = GameObject.Find("fade_white2");

        refKirakira = (GameObject)Resources.Load("kirakira");

        if (StageSelectController.barNum >= 0 && StageSelectController.barNum < 6)
        {
            refObjicon = (GameObject)Resources.Load("icon_1");
        }
        if (StageSelectController.barNum >= 6 && StageSelectController.barNum < 11)
        {
            refObjicon = (GameObject)Resources.Load("icon_2");
        }
        if (StageSelectController.barNum >= 11 && StageSelectController.barNum < 16)
        {
            refObjicon = (GameObject)Resources.Load("icon_3");
        }
        if (StageSelectController.barNum >= 16 && StageSelectController.barNum <= 20)
        {
            refObjicon = (GameObject)Resources.Load("icon_4");
        }

        Zero = (GameObject)Resources.Load("Numeral/Zero2");
        One = (GameObject)Resources.Load("Numeral/One2");
        Two = (GameObject)Resources.Load("Numeral/Two2");
        Three = (GameObject)Resources.Load("Numeral/Three2");
        Four = (GameObject)Resources.Load("Numeral/Four2");
        Five = (GameObject)Resources.Load("Numeral/Five2");
        Six = (GameObject)Resources.Load("Numeral/Six2");
        Seven = (GameObject)Resources.Load("Numeral/Seven2");
        Eight = (GameObject)Resources.Load("Numeral/Eight2");
        Nine = (GameObject)Resources.Load("Numeral/Nine2");
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
            cloneResult = Instantiate(result, new Vector3(refObj2.transform.position.x - initialPos, 0.0f, 0.0f), Quaternion.identity);
        }

        if (!cloneObjIcon)
        {
            cloneObjIcon = Instantiate(refObjicon, new Vector3(refObj2.transform.position.x - initialPos - 3.9f, 0.0f, 0.0f), Quaternion.identity);
        }

        if (!cloneMenu)
        {
            cloneMenu = Instantiate(refObjMenu, new Vector3(refObj2.transform.position.x - initialPos, 0.0f, 0.0f), Quaternion.identity);
        }

        if (cloneResult.transform.position.x < refObj2.transform.position.x)
        {
            cloneResult.transform.position += new Vector3(move * Time.deltaTime, 0.0f, 0.0f);
            cloneObjIcon.transform.position += new Vector3(move * Time.deltaTime, 0.0f, 0.0f);
            cloneMenu.transform.position += new Vector3(move * Time.deltaTime, 0.0f, 0.0f);
        }
        else
        {
            moveEndFlag = true;
        }
    }

    private void SetScore()
    {
        tempScore += plusScore;

        // 桁数計算
        int number = tempScore;

        int digit = 0;

        while (number > 0)
        {
            number = number / 10;
            digit += 1;
        }

        if (digit == 0)
        {
            digit = 1;
        }

        number = tempScore;

        if (!scoreEndFlag)
        {
            if (deleteFlag)
            {
                deleteFlag = false;
            }
            else
            {
                deleteFlag = true;
            }

            for (int i = 0; i < digit; i++)
            {
                // 今回表示する桁の数字
                int num = (int)(number % 10);

                if (num == 0)
                {
                    GameObject cloneNum = Instantiate(Zero, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
                }

                if (num == 1)
                {
                    GameObject cloneNum = Instantiate(One, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
                }

                if (num == 2)
                {
                    GameObject cloneNum = Instantiate(Two, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
                }

                if (num == 3)
                {
                    GameObject cloneNum = Instantiate(Three, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
                }

                if (num == 4)
                {
                    GameObject cloneNum = Instantiate(Four, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
                }

                if (num == 5)
                {
                    GameObject cloneNum = Instantiate(Five, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
                }

                if (num == 6)
                {
                    GameObject cloneNum = Instantiate(Six, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
                }

                if (num == 7)
                {
                    GameObject cloneNum = Instantiate(Seven, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
                }

                if (num == 8)
                {
                    GameObject cloneNum = Instantiate(Eight, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
                }

                if (num == 9)
                {
                    GameObject cloneNum = Instantiate(Nine, new Vector3(refObj2.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
                }

                // 次の桁へ
                number /= 10;
            }
        }

        if (tempScore == refObj.GetComponent<PlayerScript>().score)
        {
            int i = PlayerPrefs.GetInt("StageScore" + StageSelectController.barNum.ToString("00"));
            if (i < refObj.GetComponent<PlayerScript>().score && !refObj.GetComponent<PlayerScript>().tutorialFlag)
            {
                PlayerPrefs.SetInt("StageScore" + StageSelectController.barNum.ToString("00"), refObj.GetComponent<PlayerScript>().score);
            }

            scoreEndFlag = true;
        }
    }

    private void SetRank()
    {
        if (!cloneKirakira)
        {
            cloneKirakira = Instantiate(refKirakira, new Vector3(refObj2.transform.position.x + PosKiX, PosKiY, 0.0f), Quaternion.identity);
        }
         
        // スコアランクを表示する

        if (!cloneRank)
        {
            if(Rank_SSS <= refObj.GetComponent<PlayerScript>().score)
            {
                GameObject Rank = (GameObject)Resources.Load("ScoreRank/RankSSS");
                cloneRank = Instantiate(Rank, new Vector3(refObj2.transform.position.x + PosXr, PosYr, 0.0f), Quaternion.identity);
               
                if (!refObj.GetComponent<PlayerScript>().tutorialFlag)
                {
                    PlayerPrefs.SetInt("StageRank" + StageSelectController.barNum.ToString("00"), 7);
                }
            }

            if (Rank_SSS > refObj.GetComponent<PlayerScript>().score && refObj.GetComponent<PlayerScript>().score >= Rank_SS)
            {
                GameObject Rank = (GameObject)Resources.Load("ScoreRank/RankSS");
                cloneRank = Instantiate(Rank, new Vector3(refObj2.transform.position.x + PosXr, PosYr, 0.0f), Quaternion.identity);

                int i = PlayerPrefs.GetInt("StageRank" + StageSelectController.barNum.ToString("00"));
                if (i < 6 && !refObj.GetComponent<PlayerScript>().tutorialFlag)
                {
                    PlayerPrefs.SetInt("StageRank" + StageSelectController.barNum.ToString("00"), 6);
                }
            }

            if (Rank_SS > refObj.GetComponent<PlayerScript>().score && refObj.GetComponent<PlayerScript>().score >= Rank_S)
            {
                GameObject Rank = (GameObject)Resources.Load("ScoreRank/RankS");
                cloneRank = Instantiate(Rank, new Vector3(refObj2.transform.position.x + PosXr, PosYr, 0.0f), Quaternion.identity);

                int i = PlayerPrefs.GetInt("StageRank" + StageSelectController.barNum.ToString("00"));
                if (i < 5 && !refObj.GetComponent<PlayerScript>().tutorialFlag)
                {
                    PlayerPrefs.SetInt("StageRank" + StageSelectController.barNum.ToString("00"), 5);
                }
            }

            if (Rank_S > refObj.GetComponent<PlayerScript>().score && refObj.GetComponent<PlayerScript>().score >= Rank_A)
            {
                GameObject Rank = (GameObject)Resources.Load("ScoreRank/RankA");
                cloneRank = Instantiate(Rank, new Vector3(refObj2.transform.position.x + PosXr, PosYr, 0.0f), Quaternion.identity);

                int i = PlayerPrefs.GetInt("StageRank" + StageSelectController.barNum.ToString("00"));
                if (i < 4 && !refObj.GetComponent<PlayerScript>().tutorialFlag)
                {
                    PlayerPrefs.SetInt("StageRank" + StageSelectController.barNum.ToString("00"), 4);
                }
            }

            if (Rank_A > refObj.GetComponent<PlayerScript>().score && refObj.GetComponent<PlayerScript>().score >= Rank_B)
            {
                GameObject Rank = (GameObject)Resources.Load("ScoreRank/RankB");
                cloneRank = Instantiate(Rank, new Vector3(refObj2.transform.position.x + PosXr, PosYr, 0.0f), Quaternion.identity);

                int i = PlayerPrefs.GetInt("StageRank" + StageSelectController.barNum.ToString("00"));
                if (i < 3 && !refObj.GetComponent<PlayerScript>().tutorialFlag)
                {
                    PlayerPrefs.SetInt("StageRank" + StageSelectController.barNum.ToString("00"), 3);
                }
            }

            if (Rank_B > refObj.GetComponent<PlayerScript>().score && refObj.GetComponent<PlayerScript>().score >= Rank_C)
            {
                GameObject Rank = (GameObject)Resources.Load("ScoreRank/RankC");
                cloneRank = Instantiate(Rank, new Vector3(refObj2.transform.position.x + PosXr, PosYr, 0.0f), Quaternion.identity);

                int i = PlayerPrefs.GetInt("StageRank" + StageSelectController.barNum.ToString("00"));
                if (i < 2 && !refObj.GetComponent<PlayerScript>().tutorialFlag)
                {
                    PlayerPrefs.SetInt("StageRank" + StageSelectController.barNum.ToString("00"), 2);
                }
            }

            if (Rank_C > refObj.GetComponent<PlayerScript>().score)
            {
                GameObject Rank = (GameObject)Resources.Load("ScoreRank/RankD");
                cloneRank = Instantiate(Rank, new Vector3(refObj2.transform.position.x + PosXr, PosYr, 0.0f), Quaternion.identity);

                int i = PlayerPrefs.GetInt("StageRank" + StageSelectController.barNum.ToString("00"));
                if (i < 1 && !refObj.GetComponent<PlayerScript>().tutorialFlag)
                {
                    PlayerPrefs.SetInt("StageRank" + StageSelectController.barNum.ToString("00"), 1);
                }
            }

            cloneRank.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        }

        if (cloneRank)
        {
            if(cloneRank.transform.localScale.x < MaxScale)
            {
                cloneRank.transform.localScale += new Vector3(ScaleAmount * Time.deltaTime, ScaleAmount * Time.deltaTime, 0.0f);
            }
            else
            {
                rankEndFlag = true;
            }
        }

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
                    if (Gamepad.current.buttonSouth.wasPressedThisFrame || Gamepad.current.buttonEast.wasPressedThisFrame || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
                    {
                        fadeObj.transform.position = new Vector3(refObj2.transform.position.x, refObj2.transform.position.y, 0.0f);
                        fadeObj.GetComponent<FadeScript>().isFadeOut = true;
                        oneTimeFlag = true;
                    }
                }
            }

            if (fadeObj.GetComponent<FadeScript>().fadeEndFlag)
            {
                if (refObj.GetComponent<PlayerScript>().tutorialFlag)
                {
                    PlayerPrefs.SetInt("tutorial", 1);
                }

                SceneManager.LoadScene("StageSelectScene");
            }
        }
    }
}
