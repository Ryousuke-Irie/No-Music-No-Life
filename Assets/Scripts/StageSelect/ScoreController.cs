using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int barNum_s;

    [Header("No")] public GameObject scr;
    [Header("SSS")] public GameObject scr1;
    [Header("SS")] public GameObject scr2;
    [Header("S")] public GameObject scr3;
    [Header("A")] public GameObject scr4;
    [Header("B")] public GameObject scr5;
    [Header("C")] public GameObject scr6;
    [Header("D")] public GameObject scr7;

    GameObject[] scrBox;
    private int scrNum = 0;

    [System.NonSerialized] public bool deleteFlag = true;

    private float PosX = 0.4f;
    private float PosY = 2.0f;

    private float Between = 0.6f;

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

    private GameObject refObj;

    // Start is called before the first frame update
    void Start()
    {
        scrBox = new GameObject[]
        {
            scr ,scr1, scr2, scr3, scr4, scr5, scr6, scr7
        };

        barNum_s = StageSelectController.getBarNum();
        // 表示取得
        for (int i = 0; i < 20; i++)
        {
            scrBox[scrNum].SetActive(false);
        }

        refObj = GameObject.Find("menu_bar");

        Zero = (GameObject)Resources.Load("Numeral/Zero3");
        One = (GameObject)Resources.Load("Numeral/One3");
        Two = (GameObject)Resources.Load("Numeral/Two3");
        Three = (GameObject)Resources.Load("Numeral/Three3");
        Four = (GameObject)Resources.Load("Numeral/Four3");
        Five = (GameObject)Resources.Load("Numeral/Five3");
        Six = (GameObject)Resources.Load("Numeral/Six3");
        Seven = (GameObject)Resources.Load("Numeral/Seven3");
        Eight = (GameObject)Resources.Load("Numeral/Eight3");
        Nine = (GameObject)Resources.Load("Numeral/Nine3");
    }

    // Update is called once per frame
    void Update()
    {
       
        barNum_s = StageSelectController.getBarNum();

        for (int i = 0; i < 20; i++)
		{
            scrBox[scrNum].SetActive(false);
		}

        scrNum = PlayerPrefs.GetInt("StageRank" + barNum_s.ToString("00"));

        switch (barNum_s)
        {
            case 0:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 1:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 2:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 3:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 4:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 5:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 6:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 7:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 8:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 9:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 10:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 11:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 12:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 13:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 14:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 15:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 16:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 17:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 18:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            case 19:
                // 表示取得
                scrBox[scrNum].SetActive(true);
                break;
            default:
                break;
        }

        // 桁数計算
        int number = PlayerPrefs.GetInt("StageScore" + barNum_s.ToString("00"));

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

        number = PlayerPrefs.GetInt("StageScore" + barNum_s.ToString("00"));


        if (deleteFlag)
        {
            deleteFlag = false;
        }
        else
        {
            deleteFlag = true;
        }

        if (refObj.GetComponent<SettingButtonController>().mStatus || refObj.GetComponent<SettingButtonController>().transFlagR) { return; }

        for (int i = 0; i < digit; i++)
        {
            // 今回表示する桁の数字
            int num = (int)(number % 10);

            if (num == 0)
            {
                GameObject cloneNum = Instantiate(Zero, new Vector3(PosX - i * Between + (digit - 1) * 0.3f, PosY, 0.0f), Quaternion.identity);
            }

            if (num == 1)
            {
                GameObject cloneNum = Instantiate(One, new Vector3(PosX - i * Between + (digit - 1) * 0.3f, PosY, 0.0f), Quaternion.identity);
            }

            if (num == 2)
            {
                GameObject cloneNum = Instantiate(Two, new Vector3(PosX - i * Between + (digit - 1) * 0.3f, PosY, 0.0f), Quaternion.identity);
            }

            if (num == 3)
            {
                GameObject cloneNum = Instantiate(Three, new Vector3(PosX - i * Between + (digit - 1) * 0.3f, PosY, 0.0f), Quaternion.identity);
            }

            if (num == 4)
            {
                GameObject cloneNum = Instantiate(Four, new Vector3(PosX - i * Between + (digit - 1) * 0.3f, PosY, 0.0f), Quaternion.identity);
            }

            if (num == 5)
            {
                GameObject cloneNum = Instantiate(Five, new Vector3(PosX - i * Between + (digit - 1) * 0.3f, PosY, 0.0f), Quaternion.identity);
            }

            if (num == 6)
            {
                GameObject cloneNum = Instantiate(Six, new Vector3(PosX - i * Between + (digit - 1) * 0.3f, PosY, 0.0f), Quaternion.identity);
            }

            if (num == 7)
            {
                GameObject cloneNum = Instantiate(Seven, new Vector3(PosX - i * Between + (digit - 1) * 0.3f, PosY, 0.0f), Quaternion.identity);
            }

            if (num == 8)
            {
                GameObject cloneNum = Instantiate(Eight, new Vector3(PosX - i * Between + (digit - 1) * 0.3f, PosY, 0.0f), Quaternion.identity);
            }

            if (num == 9)
            {
                GameObject cloneNum = Instantiate(Nine, new Vector3(PosX - i * Between + (digit - 1) * 0.3f, PosY, 0.0f), Quaternion.identity);
            }

            // 次の桁へ
            number /= 10;
        }
    }
}
