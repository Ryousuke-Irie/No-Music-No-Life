using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class SettingButtonController : MonoBehaviour
{
    [Header("オブジェクト1")] public GameObject menu1;
    [Header("オブジェクト2")] public GameObject menu2;
    [Header("オブジェクト3")] public GameObject menu3;
    [Header("オブジェクト4")] public GameObject menu4;
    [Header("オブジェクト5")] public GameObject menu5;

    [System.NonSerialized] public bool mStatus = false;
    private Animator anim = null;

    private float ySpeed_config = 20.0f;
    private bool transFlag = false;
    [System.NonSerialized] public bool transFlagR = false;

    SoundManager soundManager;

    private GameObject refObj;

    private GameObject refObjSA;
    private GameObject refObjSB;
    private GameObject refObjSS;

    public GameObject refObjHandle1;
    public GameObject refObjHandle2;
    public GameObject refObjHandle3;

    private byte r = 255;
    private byte g = 255;
    private byte b = 145;

    private int Now = 0;

    private bool oneTimeFlag1 = false;
    private bool oneTimeFlag2 = false;
    private bool oneTimeFlag3 = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        soundManager = FindObjectOfType<SoundManager>();

        refObj = GameObject.Find("menu_bar");

        refObjSA = GameObject.Find("all_slider");
        refObjSB = GameObject.Find("bgm_slider");
        refObjSS = GameObject.Find("se_slider");
    }

    // Update is called once per frame
    void Update()
    {
        if (transFlag == true)
        {
            menu4.transform.position += new Vector3(0.0f, -ySpeed_config * Time.deltaTime, 0.0f);
            if (menu4.transform.localPosition.y < 1.38f)
            {
                menu4.transform.localPosition = new Vector3(-0.4079f, 1.38f, 0.0f);
                menu5.SetActive(true);
                transFlag = false;
            }
        }

        if (transFlagR == true)
        {
            menu4.transform.position += new Vector3(0.0f, ySpeed_config * Time.deltaTime, 0.0f);
            if (menu4.transform.localPosition.y > 11.4f)
            {
                menu4.transform.localPosition = new Vector3(-0.4079f, 11.4f, 0.0f);
                transFlagR = false;
            }
        }

        if (Gamepad.current != null)
        {
            if (Gamepad.current.buttonEast.wasPressedThisFrame)
            {
                soundManager.PlaySeByName("selectSE");
                Buttonclick(1);
            }

            if (Gamepad.current.buttonNorth.wasPressedThisFrame || Gamepad.current.startButton.wasPressedThisFrame)
            {
                soundManager.PlaySeByName("selectSE");
                Buttonclick(0);
            }
        }

        if (refObjSA == null)
        {
            refObjSA = GameObject.Find("all_slider");
        }
        else
        {
            if(!oneTimeFlag1)
            {
                refObjSA.GetComponent<Slider>().value = SoundController.value_all * 10;
                oneTimeFlag1 = true;
            }
        }

        if (refObjSB == null)
        {
            refObjSB = GameObject.Find("bgm_slider");
        }
        else
        {
            if (!oneTimeFlag2)
            {
                refObjSB.GetComponent<Slider>().value = SoundController.value_bgm * 10;
                oneTimeFlag2 = true;
            }
        }

        if (refObjSS == null)
        {
            refObjSS = GameObject.Find("se_slider");
        }
        else
        {
            if (!oneTimeFlag3)
            {
                refObjSS.GetComponent<Slider>().value = SoundController.value_se * 10;
                oneTimeFlag3 = true;
            }
        }

        if (refObj.GetComponent<SettingButtonController>().mStatus)
        {
            if (Gamepad.current != null)
            {
                refObjHandle1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                refObjHandle2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                refObjHandle3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);

                if (Now == 0)
                {
                    refObjHandle1.GetComponent<Image>().color = new Color32(r, g, b, 255);

                    if (Gamepad.current.dpad.left.wasPressedThisFrame)
                    {
                        soundManager.PlaySeByName("selectSE");

                        if (refObjSA.GetComponent<Slider>().value == 1) refObjSA.GetComponent<Slider>().value = 0.0f;
                        if (refObjSA.GetComponent<Slider>().value == 2) refObjSA.GetComponent<Slider>().value = 1.0f;
                        if (refObjSA.GetComponent<Slider>().value == 3) refObjSA.GetComponent<Slider>().value = 2.0f;
                        if (refObjSA.GetComponent<Slider>().value == 4) refObjSA.GetComponent<Slider>().value = 3.0f;
                        if (refObjSA.GetComponent<Slider>().value == 5) refObjSA.GetComponent<Slider>().value = 4.0f;
                        if (refObjSA.GetComponent<Slider>().value == 6) refObjSA.GetComponent<Slider>().value = 5.0f;
                        if (refObjSA.GetComponent<Slider>().value == 7) refObjSA.GetComponent<Slider>().value = 6.0f;
                        if (refObjSA.GetComponent<Slider>().value == 8) refObjSA.GetComponent<Slider>().value = 7.0f;
                        if (refObjSA.GetComponent<Slider>().value == 9) refObjSA.GetComponent<Slider>().value = 8.0f;
                        if (refObjSA.GetComponent<Slider>().value == 10) refObjSA.GetComponent<Slider>().value = 9.0f;
                    }

                    if (Gamepad.current.dpad.right.wasPressedThisFrame)
                    {
                        soundManager.PlaySeByName("selectSE");

                        if (refObjSA.GetComponent<Slider>().value == 9) refObjSA.GetComponent<Slider>().value = 10.0f;
                        if (refObjSA.GetComponent<Slider>().value == 8) refObjSA.GetComponent<Slider>().value = 9.0f;
                        if (refObjSA.GetComponent<Slider>().value == 7) refObjSA.GetComponent<Slider>().value = 8.0f;
                        if (refObjSA.GetComponent<Slider>().value == 6) refObjSA.GetComponent<Slider>().value = 7.0f;
                        if (refObjSA.GetComponent<Slider>().value == 5) refObjSA.GetComponent<Slider>().value = 6.0f;
                        if (refObjSA.GetComponent<Slider>().value == 4) refObjSA.GetComponent<Slider>().value = 5.0f;
                        if (refObjSA.GetComponent<Slider>().value == 3) refObjSA.GetComponent<Slider>().value = 4.0f;
                        if (refObjSA.GetComponent<Slider>().value == 2) refObjSA.GetComponent<Slider>().value = 3.0f;
                        if (refObjSA.GetComponent<Slider>().value == 1) refObjSA.GetComponent<Slider>().value = 2.0f;
                        if (refObjSA.GetComponent<Slider>().value == 0) refObjSA.GetComponent<Slider>().value = 1.0f;
                    }

                    if (Gamepad.current.dpad.down.wasPressedThisFrame)
                    {
                        Now = 1;
                    }
                }
                else if (Now == 1)
                {
                    refObjHandle2.GetComponent<Image>().color = new Color32(r, g, b, 255);

                    if (Gamepad.current.dpad.left.wasPressedThisFrame)
                    {
                        soundManager.PlaySeByName("selectSE");

                        if (refObjSB.GetComponent<Slider>().value == 1) refObjSB.GetComponent<Slider>().value = 0.0f;
                        if (refObjSB.GetComponent<Slider>().value == 2) refObjSB.GetComponent<Slider>().value = 1.0f;
                        if (refObjSB.GetComponent<Slider>().value == 3) refObjSB.GetComponent<Slider>().value = 2.0f;
                        if (refObjSB.GetComponent<Slider>().value == 4) refObjSB.GetComponent<Slider>().value = 3.0f;
                        if (refObjSB.GetComponent<Slider>().value == 5) refObjSB.GetComponent<Slider>().value = 4.0f;
                        if (refObjSB.GetComponent<Slider>().value == 6) refObjSB.GetComponent<Slider>().value = 5.0f;
                        if (refObjSB.GetComponent<Slider>().value == 7) refObjSB.GetComponent<Slider>().value = 6.0f;
                        if (refObjSB.GetComponent<Slider>().value == 8) refObjSB.GetComponent<Slider>().value = 7.0f;
                        if (refObjSB.GetComponent<Slider>().value == 9) refObjSB.GetComponent<Slider>().value = 8.0f;
                        if (refObjSB.GetComponent<Slider>().value == 10) refObjSB.GetComponent<Slider>().value = 9.0f;
                    }

                    if (Gamepad.current.dpad.right.wasPressedThisFrame)
                    {
                        soundManager.PlaySeByName("selectSE");

                        if (refObjSB.GetComponent<Slider>().value == 9) refObjSB.GetComponent<Slider>().value = 10.0f;
                        if (refObjSB.GetComponent<Slider>().value == 8) refObjSB.GetComponent<Slider>().value = 9.0f;
                        if (refObjSB.GetComponent<Slider>().value == 7) refObjSB.GetComponent<Slider>().value = 8.0f;
                        if (refObjSB.GetComponent<Slider>().value == 6) refObjSB.GetComponent<Slider>().value = 7.0f;
                        if (refObjSB.GetComponent<Slider>().value == 5) refObjSB.GetComponent<Slider>().value = 6.0f;
                        if (refObjSB.GetComponent<Slider>().value == 4) refObjSB.GetComponent<Slider>().value = 5.0f;
                        if (refObjSB.GetComponent<Slider>().value == 3) refObjSB.GetComponent<Slider>().value = 4.0f;
                        if (refObjSB.GetComponent<Slider>().value == 2) refObjSB.GetComponent<Slider>().value = 3.0f;
                        if (refObjSB.GetComponent<Slider>().value == 1) refObjSB.GetComponent<Slider>().value = 2.0f;
                        if (refObjSB.GetComponent<Slider>().value == 0) refObjSB.GetComponent<Slider>().value = 1.0f;
                    }

                    if (Gamepad.current.dpad.down.wasPressedThisFrame)
                    {
                        Now = 2;
                    }

                    if (Gamepad.current.dpad.up.wasPressedThisFrame)
                    {
                        Now = 0;
                    }
                }
                else if (Now == 2)
                {
                    refObjHandle3.GetComponent<Image>().color = new Color32(r, g, b, 255);

                    if (Gamepad.current.dpad.left.wasPressedThisFrame)
                    {
                        soundManager.PlaySeByName("selectSE");

                        if (refObjSS.GetComponent<Slider>().value == 1) refObjSS.GetComponent<Slider>().value = 0.0f;
                        if (refObjSS.GetComponent<Slider>().value == 2) refObjSS.GetComponent<Slider>().value = 1.0f;
                        if (refObjSS.GetComponent<Slider>().value == 3) refObjSS.GetComponent<Slider>().value = 2.0f;
                        if (refObjSS.GetComponent<Slider>().value == 4) refObjSS.GetComponent<Slider>().value = 3.0f;
                        if (refObjSS.GetComponent<Slider>().value == 5) refObjSS.GetComponent<Slider>().value = 4.0f;
                        if (refObjSS.GetComponent<Slider>().value == 6) refObjSS.GetComponent<Slider>().value = 5.0f;
                        if (refObjSS.GetComponent<Slider>().value == 7) refObjSS.GetComponent<Slider>().value = 6.0f;
                        if (refObjSS.GetComponent<Slider>().value == 8) refObjSS.GetComponent<Slider>().value = 7.0f;
                        if (refObjSS.GetComponent<Slider>().value == 9) refObjSS.GetComponent<Slider>().value = 8.0f;
                        if (refObjSS.GetComponent<Slider>().value == 10) refObjSS.GetComponent<Slider>().value = 9.0f;
                    }

                    if (Gamepad.current.dpad.right.wasPressedThisFrame)
                    {
                        soundManager.PlaySeByName("selectSE");

                        if (refObjSS.GetComponent<Slider>().value == 9) refObjSS.GetComponent<Slider>().value = 10.0f;
                        if (refObjSS.GetComponent<Slider>().value == 8) refObjSS.GetComponent<Slider>().value = 9.0f;
                        if (refObjSS.GetComponent<Slider>().value == 7) refObjSS.GetComponent<Slider>().value = 8.0f;
                        if (refObjSS.GetComponent<Slider>().value == 6) refObjSS.GetComponent<Slider>().value = 7.0f;
                        if (refObjSS.GetComponent<Slider>().value == 5) refObjSS.GetComponent<Slider>().value = 6.0f;
                        if (refObjSS.GetComponent<Slider>().value == 4) refObjSS.GetComponent<Slider>().value = 5.0f;
                        if (refObjSS.GetComponent<Slider>().value == 3) refObjSS.GetComponent<Slider>().value = 4.0f;
                        if (refObjSS.GetComponent<Slider>().value == 2) refObjSS.GetComponent<Slider>().value = 3.0f;
                        if (refObjSS.GetComponent<Slider>().value == 1) refObjSS.GetComponent<Slider>().value = 2.0f;
                        if (refObjSS.GetComponent<Slider>().value == 0) refObjSS.GetComponent<Slider>().value = 1.0f;
                    }

                    if (Gamepad.current.dpad.up.wasPressedThisFrame)
                    {
                        Now = 1;
                    }
                }

            }
        }
    }

    public void Buttonclick(int number)
	{
        switch (number)
		{
            case 0:
                if(mStatus == false && transFlagR == false)
				{
                    menu1.SetActive(false);
                    menu2.SetActive(false);
                    menu3.SetActive(false);

                    anim.SetBool("start", true);

                    transFlag = true;

                    mStatus = true;
                }
                else if(mStatus == true && transFlag == false)
				{
                    menu1.SetActive(true);
                    menu2.SetActive(true);
                    menu3.SetActive(true);
                    menu5.SetActive(false);

                    anim.SetBool("start", false);

                    transFlagR = true;

                    mStatus = false;
                }
                break;
            case 1:
                if(mStatus == false)
				{
                    soundManager.StopBgm();
                    soundManager.StopSe();
                    SceneManager.LoadScene("TitleScene");
                }
                break;
            default:
                break;
		}
	}
}