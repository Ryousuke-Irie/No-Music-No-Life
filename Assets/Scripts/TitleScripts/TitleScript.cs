
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//’Ç‰Á
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class TitleScript : MonoBehaviour
{
    GameObject refObj;

    private bool endFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("fade_white");
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamepad.current == null)
        {
            if (Input.anyKeyDown)
            {
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
        SceneManager.LoadScene("StageSelectScene");
    }
}