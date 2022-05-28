using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//’Ç‰Á
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class TitleScript : MonoBehaviour
{
    GameObject refObj;

    GameObject refObj;
    public SoundManager soundManager;

    private bool endFlag = false;
    private bool bgmFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("fade_white3");
    }

    // Update is called once per frame
    void Update()
    {
            if (bgmFlag == false)
            {
                PlayTitleBGM();
                bgmFlag = true;
            }

            if (Gamepad.current == null)
        {
            if (Input.anyKeyDown)
            {
                    PlayTitleSE();

                    if (refObj != null)
                {
                    refObj.GetComponent<FadeScript>().isFadeOut = true;
                }
            }
        }
        else
        {
            if (Input.anyKeyDown || 
                Gamepad.current.buttonEast.wasPressedThisFrame ||
                Gamepad.current.buttonWest.wasPressedThisFrame ||
                Gamepad.current.buttonNorth.wasPressedThisFrame ||
                Gamepad.current.buttonSouth.wasPressedThisFrame ||
                Gamepad.current.startButton.wasPressedThisFrame ||
                Gamepad.current.selectButton.wasPressedThisFrame ||
                Gamepad.current.leftShoulder.wasPressedThisFrame ||
                Gamepad.current.rightShoulder.wasPressedThisFrame)
            {
                    PlayTitleSE();

                    if (refObj != null)
                {
                    refObj.GetComponent<FadeScript>().isFadeOut = true;
                }
            }
        }

        if (refObj != null)
        {
            if (refObj.GetComponent<FadeScript>().fadeEndFlag)
            {
                endFlag = true;
            }
        }

        if(endFlag)
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        soundManager.StopBgm();
        bgmFlag = false;

        int tutorial = PlayerPrefs.GetInt("tutorial");
        if(tutorial == 0)
        {
            SceneManager.LoadScene("TutorialStageScene");
        }
        else
        {
            SceneManager.LoadScene("StageSelectScene");
        }
    }

    public void PlayTitleBGM()
	{
        soundManager.PlayBgmByName("S.H.R. pop_in");
	}
    public void PlayTitleSE()
	{
        soundManager.PlaySeByName("decisionSE");
	}

}