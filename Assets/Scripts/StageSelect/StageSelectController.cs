using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StageSelectController : MonoBehaviour
{
    [Header("スケールを変えたいオブジェクト1")] public GameObject bar1;
    [Header("スケールを変えたいオブジェクト2")] public GameObject bar2;
    [Header("スケールを変えたいオブジェクト3")] public GameObject bar3;
    [Header("スケールを変えたいオブジェクト4")] public GameObject bar4;
    [Header("スケールを変えたいオブジェクト5")] public GameObject bar5;
    [Header("スケールを変えたいオブジェクト6")] public GameObject bar6;
    [Header("スケールを変えたいオブジェクト7")] public GameObject bar7;
    [Header("スケールを変えたいオブジェクト8")] public GameObject bar8;
    [Header("スケールを変えたいオブジェクト9")] public GameObject bar9;
    [Header("スケールを変えたいオブジェクト10")] public GameObject bar10;

    GameObject[] barBox;

    [Header("イメージオブジェクト1")] public GameObject image1;
    [Header("イメージオブジェクト2")] public GameObject image2;
    [Header("イメージオブジェクト3")] public GameObject image3;
    [Header("イメージオブジェクト4")] public GameObject image4;
    [Header("イメージオブジェクト5")] public GameObject image5;
    [Header("イメージオブジェクト6")] public GameObject image6;
    [Header("イメージオブジェクト7")] public GameObject image7;
    [Header("イメージオブジェクト8")] public GameObject image8;
    [Header("イメージオブジェクト9")] public GameObject image9;
    [Header("イメージオブジェクト10")] public GameObject image10;

    GameObject[] imageBox;

    public float SscaleX;
    public float SscaleY;
    public float S1positionX;
    public float S1positionY;
    public float S2positionX;
    public float S2positionY;
    public float S3positionX;
    public float S3positionY;
    public float BpositionX;
    public float BpositionY;
    public float BscaleX;
    public float BscaleY;
    
    [Header("スピードX")] public float speedX;
    [Header("スピードY")] public float speedY;
    [Header("スケールスピードX")] public float sclspeedX;
    [Header("スケールスピードY")] public float sclspeedY;

    private int barNum = 0;
    private int imageNum = 0;
    private int timeCnt = 0;
    private bool transFlagS = false;
    private bool transFlagW = false;
    private Vector3 speed = new Vector3((float)0.1, (float)0.1, 0);

    public Image image;
    private Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        barBox = new GameObject[]
        {
            bar1, bar2, bar3, bar4, bar5, bar6, bar7, bar8, bar9, bar10
        };

        imageBox = new GameObject[]
        {
            image1, image2, image3, image4, image5, image6, image7, image8, image9, image10
        };

        for (int i = 0; i < 10; i++)
		{
            barBox[i].SetActive(false);
		}

        for (int i = 0; i < 10; i++)
		{
            imageBox[i].SetActive(false);
		}

        barBox[8].SetActive(true);
        barBox[8].transform.position = new Vector3(S1positionX + (float)-2.0, S1positionY + (float)-2.0, 0.0f);
        barBox[8].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

        barBox[9].SetActive(true);
        barBox[9].transform.position = new Vector3(S2positionX, S2positionY, 0.0f);
        barBox[9].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

        barBox[0].SetActive(true);
        barBox[0].transform.position = new Vector3(BpositionX, BpositionY, 0.0f);
        barBox[0].transform.localScale = new Vector3(BscaleX, BscaleY, 0.0f);

        barBox[1].SetActive(true);
        barBox[1].transform.position = new Vector3(S3positionX + (float)-2.0, S3positionY + (float)2.0, 0.0f);
        barBox[1].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

        imageBox[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && transFlagS == false)
		{
            transFlagS = true;
            barNum += 1;

            if (barNum > 9)
            {
                barNum = 0;
            }

            if (barNum == 0 || barNum == 1 || barNum == 2)
            {
                barBox[barNum + 7].SetActive(false);
                barBox[barNum + 1].SetActive(true);
                barBox[barNum + 1].transform.position = new Vector3(S3positionX, S3positionY, 0.0f);
                barBox[barNum + 1].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
            }
            else if (barNum == 9)
            {
                barBox[barNum - 3].SetActive(false);
                barBox[barNum - 9].SetActive(true);
                barBox[barNum - 9].transform.position = new Vector3(S3positionX, S3positionY, 0.0f);
                barBox[barNum - 9].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
            }
            else
            {
                barBox[barNum - 3].SetActive(false);
                barBox[barNum + 1].SetActive(true);
                barBox[barNum + 1].transform.position = new Vector3(S3positionX, S3positionY, 0.0f);
                barBox[barNum + 1].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
            }

            for (int i = 0; i < 10; i++)
            {
                imageBox[i].SetActive(false);
            }

            imageBox[barNum].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.W) && transFlagW == false)
		{
            transFlagW = true;
            barNum -= 1;

            if (barNum < 0)
			{
                barNum = 9;
			}

            if (barNum == 9 || barNum == 8)
			{
                barBox[barNum - 8].SetActive(false);
                barBox[barNum - 2].SetActive(true);
                barBox[barNum - 2].transform.position = new Vector3(S1positionX, S1positionY, 0.0f);
                barBox[barNum - 2].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
            }
            else if (barNum == 1 || barNum == 0)
            {
                barBox[barNum + 2].SetActive(false);
                barBox[barNum + 8].SetActive(true);
                barBox[barNum + 8].transform.position = new Vector3(S1positionX, S1positionY, 0.0f);
                barBox[barNum + 8].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
            }
            else
            {
                barBox[barNum + 2].SetActive(false);
                barBox[barNum - 2].SetActive(true);
                barBox[barNum - 2].transform.position = new Vector3(S1positionX, S1positionY, 0.0f);
                barBox[barNum - 2].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
            }
        }

        for (int i = 0; i < 10; i++)
        {
            imageBox[i].SetActive(false);
        }

        imageBox[barNum].SetActive(true);

        if (transFlagS == true)
		{
            if (barNum == 1)
			{
                barBox[barNum + 8].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum - 1].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum - 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, speedY, 0);
                barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(-speedX, speedY, 0);
                timeCnt += 1;
                if (timeCnt > 40)
                {
                    transFlagS = false;
                    timeCnt = 0;
                }
            }
            else if (barNum == 9)
            {
                barBox[barNum - 2].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum - 1].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum - 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, speedY, 0);
                barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum - 9].transform.position += new Vector3(-speedX, speedY, 0);
                timeCnt += 1;
                if (timeCnt > 40)
                {
                    transFlagS = false;
                    timeCnt = 0;
                }
            }
            else if (barNum == 0)
            {
                barBox[barNum + 8].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum + 9].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum + 9].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, speedY, 0);
                barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(-speedX, speedY, 0);
                timeCnt += 1;
                if (timeCnt > 40)
                {
                    transFlagS = false;
                    timeCnt = 0;
                }
            }
            else
            {
                barBox[barNum - 2].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum - 1].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum - 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, speedY, 0);
                barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(-speedX, speedY, 0);
                timeCnt += 1;
                if (timeCnt > 40)
                {
                    transFlagS = false;
                    timeCnt = 0;
                }
            }
        }
        else if (transFlagW == true)
        {
            if (barNum == 9)
            {
                barBox[barNum - 2].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum - 1].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum - 9].transform.position += new Vector3(speedX, -speedY, 0);
                barBox[barNum - 9].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                timeCnt += 1;
                if (timeCnt > 40)
                {
                    transFlagW = false;
                    timeCnt = 0;
                }
            }
            else if (barNum == 1)
            {
                barBox[barNum + 8].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum - 1].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(speedX, -speedY, 0);
                barBox[barNum + 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                timeCnt += 1;
                if (timeCnt > 40)
                {
                    transFlagW = false;
                    timeCnt = 0;
                }
            }
            else if (barNum == 0)
            {
                barBox[barNum + 8].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum + 9].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(speedX, -speedY, 0);
                barBox[barNum + 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                timeCnt += 1;
                if (timeCnt > 40)
                {
                    transFlagW = false;
                    timeCnt = 0;
                }
            }
            else
            {
                barBox[barNum - 2].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum - 1].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(speedX, -speedY, 0);
                barBox[barNum + 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                timeCnt += 1;
                if (timeCnt > 40)
                {
                    transFlagW = false;
                    timeCnt = 0;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
		{
            switch (barNum)
            {
                case 0:
                    SceneManager.LoadScene("FirstStageScene");
                    break;
                case 1:
                    SceneManager.LoadScene("FirstStageScene");
                    break;
                case 2:
                    SceneManager.LoadScene("FirstStageScene");
                    break;
                case 3:
                    SceneManager.LoadScene("FirstStageScene");
                    break;
                case 4:
                    SceneManager.LoadScene("FirstStageScene");
                    break;
                case 5:
                    SceneManager.LoadScene("FirstStageScene");
                    break;
                case 6:
                    SceneManager.LoadScene("FirstStageScene");
                    break;
                case 7:
                    SceneManager.LoadScene("FirstStageScene");
                    break;
                case 8:
                    SceneManager.LoadScene("FirstStageScene");
                    break;
                case 9:
                    SceneManager.LoadScene("FirstStageScene");
                    break;
                default:
                    break;
            }
        }
    }
}
