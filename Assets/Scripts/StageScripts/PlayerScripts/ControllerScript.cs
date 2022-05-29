using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ControllerScript : MonoBehaviour
{
    public float DeadZone = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // コントローラー判定
        if (Gamepad.current == null)
        {
            // キーボードのみの処理
            Keyboard();
        }
        else
        {
            // コントローラーとキーボードの処理
            Keyboard();
            Controller();
        }
    }

    private void Keyboard()
    {
        // 移動処理
        if (Input.GetKeyDown(KeyCode.UpArrow) && (this.transform.position.x > this.GetComponent<PlayerScript>().dist - this.GetComponent<PlayerScript>().TempoTimeError && this.transform.position.x < this.GetComponent<PlayerScript>().dist + this.GetComponent<PlayerScript>().TempoTimeError) && !this.GetComponent<PlayerScript>().actionFlag)
        {
            this.GetComponent<PlayerScript>().moveUpFlag = true;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && (this.transform.position.x > this.GetComponent<PlayerScript>().dist - this.GetComponent<PlayerScript>().TempoTimeError && this.transform.position.x < this.GetComponent<PlayerScript>().dist + this.GetComponent<PlayerScript>().TempoTimeError) && !this.GetComponent<PlayerScript>().actionFlag)
        {
            this.GetComponent<PlayerScript>().moveDownFlag = true;
        }

        // 攻撃処理
        if (Input.GetKeyDown(KeyCode.Space) && (this.transform.position.x > this.GetComponent<PlayerScript>().dist - this.GetComponent<PlayerScript>().TempoTimeError && this.transform.position.x < this.GetComponent<PlayerScript>().dist + this.GetComponent<PlayerScript>().TempoTimeError) && !this.GetComponent<PlayerScript>().actionFlag)
        {
            this.GetComponent<PlayerScript>().attackFlag = true;
        }

        // 溜め処理
        if (Input.GetKeyDown(KeyCode.C) && (this.transform.position.x > this.GetComponent<PlayerScript>().dist - this.GetComponent<PlayerScript>().TempoTimeError && this.transform.position.x < this.GetComponent<PlayerScript>().dist + this.GetComponent<PlayerScript>().TempoTimeError) && !this.GetComponent<PlayerScript>().actionFlag)
        {
            this.GetComponent<PlayerScript>().chargeFlag = true;
        }

        // 戻る
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("StageSelectScene");
        }
    }

    private void Controller()
    {
        // 移動処理
        if ((Gamepad.current.dpad.up.wasPressedThisFrame || Gamepad.current.leftStick.ReadValue().y > DeadZone) && (this.transform.position.x > this.GetComponent<PlayerScript>().dist - this.GetComponent<PlayerScript>().TempoTimeError && this.transform.position.x < this.GetComponent<PlayerScript>().dist + this.GetComponent<PlayerScript>().TempoTimeError) && !this.GetComponent<PlayerScript>().actionFlag)
        {
            this.GetComponent<PlayerScript>().moveUpFlag = true;
        }

        if ((Gamepad.current.dpad.down.wasPressedThisFrame || Gamepad.current.leftStick.ReadValue().y < -DeadZone) && (this.transform.position.x > this.GetComponent<PlayerScript>().dist - this.GetComponent<PlayerScript>().TempoTimeError && this.transform.position.x < this.GetComponent<PlayerScript>().dist + this.GetComponent<PlayerScript>().TempoTimeError) && !this.GetComponent<PlayerScript>().actionFlag)
        {
            this.GetComponent<PlayerScript>().moveDownFlag = true;
        }

        // 攻撃処理
        if ((Gamepad.current.buttonEast.wasPressedThisFrame
            || Gamepad.current.buttonWest.wasPressedThisFrame || Gamepad.current.rightShoulder.wasPressedThisFrame || Gamepad.current.leftShoulder.wasPressedThisFrame)
             && (this.transform.position.x > this.GetComponent<PlayerScript>().dist - this.GetComponent<PlayerScript>().TempoTimeError && this.transform.position.x < this.GetComponent<PlayerScript>().dist + this.GetComponent<PlayerScript>().TempoTimeError) && !this.GetComponent<PlayerScript>().actionFlag)
        {
            this.GetComponent<PlayerScript>().attackFlag = true;
        }

        // 溜め処理
        if (Gamepad.current.buttonNorth.wasPressedThisFrame && (this.transform.position.x > this.GetComponent<PlayerScript>().dist - this.GetComponent<PlayerScript>().TempoTimeError && this.transform.position.x < this.GetComponent<PlayerScript>().dist + this.GetComponent<PlayerScript>().TempoTimeError) && !this.GetComponent<PlayerScript>().actionFlag)
        {
            this.GetComponent<PlayerScript>().chargeFlag = true;
        }

        // 戻る
        if (Gamepad.current.selectButton.wasPressedThisFrame)
        {
            SceneManager.LoadScene("StageSelectScene");
        }
    }
}
