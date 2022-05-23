using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RendaZoneScript : MonoBehaviour
{
    GameObject refObj;
    public float sizeX = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");

        this.GetComponent<SpriteRenderer>().size = new Vector2(sizeX, this.GetComponent<SpriteRenderer>().size.y);
        this.transform.localScale = new Vector3(sizeX, this.transform.localScale.y, this.transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (((this.transform.position.x - this.GetComponent<SpriteRenderer>().size.x * 0.5f < refObj.transform.position.x) && (this.transform.position.x + this.GetComponent<SpriteRenderer>().size.x * 0.5f > refObj.transform.position.x)) && (this.transform.position.y - this.GetComponent<SpriteRenderer>().size.y * 0.5f < refObj.transform.position.y) && (this.transform.position.y + this.GetComponent<SpriteRenderer>().size.y * 0.5f > refObj.transform.position.y))
        {
            refObj.GetComponent<PlayerScript>().actionFlag = false;

            // コントローラー判定
            if (Gamepad.current == null)
            {
                // キーボードのみの処理
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    refObj.GetComponent<PlayerScript>().attackFlag = true;
                }
            }
            else
            {
                // コントローラーとキーボードの処理
                if (Input.GetKeyDown(KeyCode.Space) || Gamepad.current.buttonEast.wasPressedThisFrame || Gamepad.current.buttonWest.wasPressedThisFrame || Gamepad.current.rightShoulder.wasPressedThisFrame || Gamepad.current.leftShoulder.wasPressedThisFrame)
                {
                    refObj.GetComponent<PlayerScript>().attackFlag = true;
                }
            }
        }
    }
}
