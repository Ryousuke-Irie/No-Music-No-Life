using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectController : MonoBehaviour
{
    [Header("�X�P�[����ς������I�u�W�F�N�g1")] public GameObject bar1;
    [Header("�X�P�[����ς������I�u�W�F�N�g2")] public GameObject bar2;
    [Header("�X�P�[����ς������I�u�W�F�N�g3")] public GameObject bar3;
    [Header("�X�P�[����ς������I�u�W�F�N�g4")] public GameObject bar4;
    [Header("�X�P�[����ς������I�u�W�F�N�g5")] public GameObject bar5;
    [Header("�X�P�[����ς������I�u�W�F�N�g6")] public GameObject bar6;
    [Header("�X�P�[����ς������I�u�W�F�N�g7")] public GameObject bar7;
    [Header("�X�P�[����ς������I�u�W�F�N�g8")] public GameObject bar8;
    [Header("�X�P�[����ς������I�u�W�F�N�g9")] public GameObject bar9;
    [Header("�X�P�[����ς������I�u�W�F�N�g10")] public GameObject bar10;
    [Header("�X�P�[����ς������I�u�W�F�N�g11")] public GameObject bar11;
    [Header("�X�P�[����ς������I�u�W�F�N�g12")] public GameObject bar12;
    [Header("�X�P�[����ς������I�u�W�F�N�g13")] public GameObject bar13;
    [Header("�X�P�[����ς������I�u�W�F�N�g14")] public GameObject bar14;
    [Header("�X�P�[����ς������I�u�W�F�N�g15")] public GameObject bar15;
    [Header("�X�P�[����ς������I�u�W�F�N�g16")] public GameObject bar16;
    [Header("�X�P�[����ς������I�u�W�F�N�g17")] public GameObject bar17;
    [Header("�X�P�[����ς������I�u�W�F�N�g18")] public GameObject bar18;
    [Header("�X�P�[����ς������I�u�W�F�N�g19")] public GameObject bar19;
    [Header("�X�P�[����ς������I�u�W�F�N�g20")] public GameObject bar20;

    GameObject[] barBox;

    [Header("�C���[�W�I�u�W�F�N�g1")] public GameObject image1;
    [Header("�C���[�W�I�u�W�F�N�g2")] public GameObject image2;
    [Header("�C���[�W�I�u�W�F�N�g3")] public GameObject image3;
    [Header("�C���[�W�I�u�W�F�N�g4")] public GameObject image4;
    [Header("�C���[�W�I�u�W�F�N�g5")] public GameObject image5;
    [Header("�C���[�W�I�u�W�F�N�g6")] public GameObject image6;
    [Header("�C���[�W�I�u�W�F�N�g7")] public GameObject image7;
    [Header("�C���[�W�I�u�W�F�N�g8")] public GameObject image8;
    [Header("�C���[�W�I�u�W�F�N�g9")] public GameObject image9;
    [Header("�C���[�W�I�u�W�F�N�g10")] public GameObject image10;
    [Header("�C���[�W�I�u�W�F�N�g11")] public GameObject image11;
    [Header("�C���[�W�I�u�W�F�N�g12")] public GameObject image12;
    [Header("�C���[�W�I�u�W�F�N�g13")] public GameObject image13;
    [Header("�C���[�W�I�u�W�F�N�g14")] public GameObject image14;
    [Header("�C���[�W�I�u�W�F�N�g15")] public GameObject image15;
    [Header("�C���[�W�I�u�W�F�N�g16")] public GameObject image16;
    [Header("�C���[�W�I�u�W�F�N�g17")] public GameObject image17;
    [Header("�C���[�W�I�u�W�F�N�g18")] public GameObject image18;
    [Header("�C���[�W�I�u�W�F�N�g19")] public GameObject image19;
    [Header("�C���[�W�I�u�W�F�N�g20")] public GameObject image20;

    GameObject[] imageBox;

	//public float SscaleX;
	//public float SscaleY;
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
    
    [Header("�X�s�[�hX")] public float speedX;
    [Header("�X�s�[�hY")] public float speedY;
    [Header("�X�P�[���X�s�[�hX")] public float sclspeedX;
    [Header("�X�P�[���X�s�[�hY")] public float sclspeedY;

    private int stageNum = 12;

    public static int barNum = 0;
    private int imageNum = 0;
    private int timeCnt = 0;
    private bool transFlagS = false;
    private bool transFlagW = false;
    private Vector3 speed;

    public Image image;
    private Sprite sprite;

    private float BspeedX, BspeedY;

    SoundManager soundManager;

    private GameObject refObj;
    private GameObject refObj2;
    private GameObject refObj3;

    private float DeadZone = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("menu_bar");
        refObj2 = GameObject.Find("fade_white");
        refObj3 = GameObject.Find("fade_white2");

        //barNum = 0;

        soundManager = FindObjectOfType<SoundManager>();
        BGMProcess();

        barBox = new GameObject[]
        {
            bar1, bar2, bar3, bar4, bar5, bar6, bar7, bar8, bar9, bar10, bar11, bar12, bar13, bar14, bar15, bar16, bar17, bar18, bar19, bar20
        };

        imageBox = new GameObject[]
        {
            image1, image2, image3, image4, image5, image6, image7, image8, image9, image10, image11, image12, image13, image14, image15, image16, image17, image18, image19, image20,
        };

        for (int i = 0; i < stageNum; i++)
		{
            barBox[i].SetActive(false);
		}

        for (int i = 0; i < stageNum; i++)
		{
            imageBox[i].SetActive(false);
		}


        if (barNum == 0)
        {
            barBox[barNum + stageNum - 2].SetActive(true);
            barBox[barNum + stageNum - 2].transform.position = new Vector3(S1positionX + (float)-2.0, S1positionY + (float)-2.0, 0.0f);
            // barBox[18].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

            barBox[barNum + stageNum - 1].SetActive(true);
            barBox[barNum + stageNum - 1].transform.position = new Vector3(S2positionX, S2positionY, 0.0f);
            // barBox[19].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

            barBox[barNum].SetActive(true);
            barBox[barNum].transform.position = new Vector3(BpositionX, BpositionY, 0.0f);
            // barBox[0].transform.localScale = new Vector3(BscaleX, BscaleY, 0.0f);

            barBox[barNum + 1].SetActive(true);
            barBox[barNum + 1].transform.position = new Vector3(S3positionX + (float)-2.0, S3positionY + (float)2.0, 0.0f);
            // barBox[1].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

        }
        else if (barNum == 1)
        {
            barBox[barNum + stageNum - 2].SetActive(true);
            barBox[barNum + stageNum - 2].transform.position = new Vector3(S1positionX + (float)-2.0, S1positionY + (float)-2.0, 0.0f);
            // barBox[18].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

            barBox[barNum - 1].SetActive(true);
            barBox[barNum - 1].transform.position = new Vector3(S2positionX, S2positionY, 0.0f);
            // barBox[19].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

            barBox[barNum].SetActive(true);
            barBox[barNum].transform.position = new Vector3(BpositionX, BpositionY, 0.0f);
            // barBox[0].transform.localScale = new Vector3(BscaleX, BscaleY, 0.0f);

            barBox[barNum + 1].SetActive(true);
            barBox[barNum + 1].transform.position = new Vector3(S3positionX + (float)-2.0, S3positionY + (float)2.0, 0.0f);
            // barBox[1].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
        }
        else if (barNum == stageNum - 1)
        {
            barBox[barNum - 2].SetActive(true);
            barBox[barNum - 2].transform.position = new Vector3(S1positionX + (float)-2.0, S1positionY + (float)-2.0, 0.0f);
            // barBox[18].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

            barBox[barNum - 1].SetActive(true);
            barBox[barNum - 1].transform.position = new Vector3(S2positionX, S2positionY, 0.0f);
            // barBox[19].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

            barBox[barNum].SetActive(true);
            barBox[barNum].transform.position = new Vector3(BpositionX, BpositionY, 0.0f);
            // barBox[0].transform.localScale = new Vector3(BscaleX, BscaleY, 0.0f);

            barBox[barNum - (stageNum - 1)].SetActive(true);
            barBox[barNum - (stageNum - 1)].transform.position = new Vector3(S3positionX + (float)-2.0, S3positionY + (float)2.0, 0.0f);
            // barBox[1].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
        }
        else
        {
            barBox[barNum - 2].SetActive(true);
            barBox[barNum - 2].transform.position = new Vector3(S1positionX + (float)-2.0, S1positionY + (float)-2.0, 0.0f);
            // barBox[18].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

            barBox[barNum - 1].SetActive(true);
            barBox[barNum - 1].transform.position = new Vector3(S2positionX, S2positionY, 0.0f);
            // barBox[19].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);

            barBox[barNum].SetActive(true);
            barBox[barNum].transform.position = new Vector3(BpositionX, BpositionY, 0.0f);
            // barBox[0].transform.localScale = new Vector3(BscaleX, BscaleY, 0.0f);

            barBox[barNum + 1].SetActive(true);
            barBox[barNum + 1].transform.position = new Vector3(S3positionX + (float)-2.0, S3positionY + (float)2.0, 0.0f);
            // barBox[1].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
        }



        imageBox[barNum].SetActive(true);

        speed = new Vector3((float)10 * Time.deltaTime, (float)10 * Time.deltaTime, 0);

        BspeedX = speedX;
        BspeedY = speedY;
    }

    // Update is called once per frame
    void Update()
    {
        speedX = BspeedX * Time.deltaTime;
        speedY = BspeedY * Time.deltaTime;

        if (refObj2) { return; }
        if (refObj.GetComponent<SettingButtonController>().mStatus || refObj.GetComponent<SettingButtonController>().transFlagR) { return; }

        if (refObj3.GetComponent<FadeScript>().fadeEndFlag)
        {
            soundManager.StopBgm();

            switch (barNum)
            {
                case 0:
                    SceneManager.LoadScene("1stStageScene");
                    break;
                case 1:
                    SceneManager.LoadScene("2ndStageScene");
                    break;
                case 2:
                    SceneManager.LoadScene("5thStageScene");
                    break;
                case 3:
                    SceneManager.LoadScene("7thStageScene");
                    break;
                case 4:
                    SceneManager.LoadScene("2ndStageScene");
                    break;
                case 5:
                    SceneManager.LoadScene("8thStageScene");
                    break;
                case 6:
                    SceneManager.LoadScene("12thStageScene");
                    break;
                case 7:
                    SceneManager.LoadScene("2ndStageScene");
                    break;
                case 8:
                    SceneManager.LoadScene("14thStageScene");
                    break;
                case 9:
                    SceneManager.LoadScene("16thStageScene");
                    break;
                case 10:
                    SceneManager.LoadScene("2ndStageScene");
                    break;
                case 11:
                    SceneManager.LoadScene("20thStageScene");
                    break;
                case 12:
                    SceneManager.LoadScene("13thStageScene");
                    break;
                case 13:
                    SceneManager.LoadScene("14thStageScene");
                    break;
                case 14:
                    SceneManager.LoadScene("15thStageScene");
                    break;
                case 15:
                    SceneManager.LoadScene("16thStageScene");
                    break;
                case 16:
                    SceneManager.LoadScene("17thStageScene");
                    break;
                case 17:
                    SceneManager.LoadScene("18thStageScene");
                    break;
                case 18:
                    SceneManager.LoadScene("19thStageScene");
                    break;
                case 19:
                    SceneManager.LoadScene("20thStageScene");
                    break;
                default:
                    break;
            }
        }

        if (refObj3.GetComponent<FadeScript>().isFadeOut) { return; }

        if (Gamepad.current == null)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) && transFlagS == false && transFlagW == false)
            {
                DownProcess();
                BGMProcess();
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) && transFlagW == false && transFlagS == false)
            {
                UpProcess();
                BGMProcess();
            }

            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
            {
                if (refObj3)
                {
                    refObj3.GetComponent<FadeScript>().isFadeOut = true;
                }
            }
        }
        else
        {
            if ((Input.GetKeyDown(KeyCode.DownArrow) || Gamepad.current.dpad.down.wasPressedThisFrame || Gamepad.current.leftStick.ReadValue().y < -DeadZone) && transFlagS == false && transFlagW == false)
            {
                DownProcess();
                BGMProcess();
            }

            if ((Input.GetKeyDown(KeyCode.UpArrow) || Gamepad.current.dpad.up.wasPressedThisFrame || Gamepad.current.leftStick.ReadValue().y > DeadZone) && transFlagW == false && transFlagS == false)
            {
                UpProcess();
                BGMProcess();
            }

            if (Gamepad.current.buttonSouth.wasPressedThisFrame || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
            {
                if (refObj3)
                {
                    refObj3.GetComponent<FadeScript>().isFadeOut = true;
                }
            }
        }


        for (int i = 0; i < stageNum; i++)
        {
            imageBox[i].SetActive(false);
        }

        imageBox[barNum].SetActive(true);


        if (transFlagS == true)
        {
            if (barNum == 1)
            {
                barBox[barNum + stageNum - 2].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum - 1].transform.position += new Vector3(speedX, speedY, 0);
                //barBox[barNum - 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, speedY, 0);
                //barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(-speedX, speedY, 0);
                timeCnt += 1;
                if (barBox[barNum].transform.position.x < BpositionX)
                {
                    transFlagS = false;
                    timeCnt = 0;
                }
            }
            else if (barNum == stageNum - 1)
            {
                barBox[barNum - 2].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum - 1].transform.position += new Vector3(speedX, speedY, 0);
                //barBox[barNum - 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, speedY, 0);
                //barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum - (stageNum - 1)].transform.position += new Vector3(-speedX, speedY, 0);
                timeCnt += 1;
                if (barBox[barNum].transform.position.x < BpositionX)
                {
                    transFlagS = false;
                    timeCnt = 0;
                }
            }
            else if (barNum == 0)
            {
                barBox[barNum + stageNum - 2].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum + stageNum - 1].transform.position += new Vector3(speedX, speedY, 0);
                //barBox[barNum + 19].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, speedY, 0);
                //barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(-speedX, speedY, 0);
                timeCnt += 1;
                if (barBox[barNum].transform.position.x < BpositionX)
                {
                    transFlagS = false;
                    timeCnt = 0;
                }
            }
            else
            {
                barBox[barNum - 2].transform.position += new Vector3(speedX, speedY, 0);
                barBox[barNum - 1].transform.position += new Vector3(speedX, speedY, 0);
                //barBox[barNum - 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, speedY, 0);
                //barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(-speedX, speedY, 0);
                timeCnt += 1;
                if (barBox[barNum].transform.position.x < BpositionX)
                {
                    transFlagS = false;
                    timeCnt = 0;
                }
            }
        }
        else if (transFlagW == true)
        {
            if (barNum == stageNum - 1)
            {
                barBox[barNum - 2].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum - 1].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, -speedY, 0);
                //barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum - (stageNum - 1)].transform.position += new Vector3(speedX, -speedY, 0);
                //barBox[barNum - 19].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                timeCnt += 1;
                if (barBox[barNum].transform.position.x < BpositionX)
                {
                    transFlagW = false;
                    timeCnt = 0;
                }
            }
            else if (barNum == 1)
            {
                barBox[barNum + stageNum - 2].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum - 1].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, -speedY, 0);
                //barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(speedX, -speedY, 0);
                //barBox[barNum + 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                timeCnt += 1;
                if (barBox[barNum].transform.position.x < BpositionX)
                {
                    transFlagW = false;
                    timeCnt = 0;
                }
            }
            else if (barNum == 0)
            {
                barBox[barNum + stageNum - 2].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum + stageNum - 1].transform.position += new Vector3(-speedX, -speedY, 0);
                barBox[barNum].transform.position += new Vector3(-speedX, -speedY, 0);
                //barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(speedX, -speedY, 0);
                //barBox[barNum + 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                timeCnt += 1;
                if (barBox[barNum].transform.position.x < BpositionX)
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
                //barBox[barNum].transform.localScale += new Vector3(sclspeedX, sclspeedY, 0);
                barBox[barNum + 1].transform.position += new Vector3(speedX, -speedY, 0);
                //barBox[barNum + 1].transform.localScale += new Vector3(-sclspeedX, -sclspeedY, 0);
                timeCnt += 1;
                if (barBox[barNum].transform.position.x < BpositionX)
                {
                    transFlagW = false;
                    timeCnt = 0;
                }
            }
        }
    }

    // ���݂�barNum���擾
    public static int getBarNum()
    {
        return barNum;
    }

    private void UpProcess()
    {
        transFlagW = true;
        barNum -= 1;

        if (barNum < 0)
        {
            barNum = stageNum - 1;
        }

        if (barNum == stageNum - 1 || barNum == stageNum - 2)
        {
            barBox[barNum - (stageNum - 2)].SetActive(false);
            barBox[barNum - 2].SetActive(true);
            barBox[barNum - 2].transform.position = new Vector3(S1positionX, S1positionY, 0.0f);
            //barBox[barNum - 2].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
        }
        else if (barNum == 1 || barNum == 0)
        {
            barBox[barNum + 2].SetActive(false);
            barBox[barNum + stageNum - 2].SetActive(true);
            barBox[barNum + stageNum - 2].transform.position = new Vector3(S1positionX, S1positionY, 0.0f);
            //barBox[barNum + 18].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
        }
        else
        {
            barBox[barNum + 2].SetActive(false);
            barBox[barNum - 2].SetActive(true);
            barBox[barNum - 2].transform.position = new Vector3(S1positionX, S1positionY, 0.0f);
            //barBox[barNum - 2].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
        }
    }

    private void DownProcess()
    {
        transFlagS = true;
        barNum += 1;

        if (barNum > stageNum - 1)
        {
            barNum = 0;
        }

        if (barNum == 0 || barNum == 1 || barNum == 2)
        {
            barBox[barNum + stageNum - 3].SetActive(false);
            barBox[barNum + 1].SetActive(true);
            barBox[barNum + 1].transform.position = new Vector3(S3positionX, S3positionY, 0.0f);
            //barBox[barNum + 1].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
        }
        else if (barNum == stageNum - 1)
        {
            barBox[barNum - 3].SetActive(false);
            barBox[barNum - (stageNum - 1)].SetActive(true);
            barBox[barNum - (stageNum - 1)].transform.position = new Vector3(S3positionX, S3positionY, 0.0f);
            //barBox[barNum - 19].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
        }
        else
        {
            barBox[barNum - 3].SetActive(false);
            barBox[barNum + 1].SetActive(true);
            barBox[barNum + 1].transform.position = new Vector3(S3positionX, S3positionY, 0.0f);
            //barBox[barNum + 1].transform.localScale = new Vector3(SscaleX, SscaleY, 0.0f);
        }

        for (int i = 0; i < stageNum; i++)
        {
            imageBox[i].SetActive(false);
        }

        imageBox[barNum].SetActive(true);
    }

    private void BGMProcess()
    {
        soundManager.StopBgm();

        switch (barNum)
        {
            case 0:
                soundManager.PlayBgmByName("stage1-1");
                break;
            case 1:
                soundManager.PlayBgmByName("stage1-2");
                break;
            case 2:
                soundManager.PlayBgmByName("stage1-5_No.01");
                break;
            case 3:
                soundManager.PlayBgmByName("stage2-2_No.11");
                break;
            case 4:
                soundManager.PlayBgmByName("stage1-2");
                break;
            case 5:
                soundManager.PlayBgmByName("stage2-3_No.16");
                break;
            case 6:
                soundManager.PlayBgmByName("stage3-2_No.09");
                break;
            case 7:
                soundManager.PlayBgmByName("stage1-2");
                break;
            case 8:
                soundManager.PlayBgmByName("stage3-4_No.05");
                break;
            case 9:
                soundManager.PlayBgmByName("stage4-1_No.04");
                break;
            case 10:
                soundManager.PlayBgmByName("stage1-2");
                break;
            case 11:
                soundManager.PlayBgmByName("Ultimate_A");
                break;
            case 12:
                soundManager.PlayBgmByName("stage3-3_No.17");
                break;
            case 13:
                soundManager.PlayBgmByName("stage3-4_No.05");
                break;
            case 14:
                soundManager.PlayBgmByName("stage1-2");
                break;
            case 15:
                soundManager.PlayBgmByName("stage4-1_No.04");
                break;
            case 16:
                soundManager.PlayBgmByName("stage4-2_No.13");
                break;
            case 17:
                soundManager.PlayBgmByName("stage4-3_No.08");
                break;
            case 18:
                soundManager.PlayBgmByName("stage4-4_No.15");
                break;
            case 19:
                soundManager.PlayBgmByName("stage1-2");
                break;
        }
    }
}
