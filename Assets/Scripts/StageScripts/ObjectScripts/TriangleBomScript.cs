using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleBomScript : MonoBehaviour
{
    private GameObject refObj;
    private GameObject refCamera;
    private bool oneTimeFlag = false;
    private bool leftFlag = true;
    private bool downFlag = false;
    private float defaultPosY = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        refCamera = GameObject.Find("Main Camera");

        defaultPosY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (leftFlag)
        {
            this.transform.position -= new Vector3(4.0f * Time.deltaTime, 0.0f, 0.0f);
        }

        if (!leftFlag)
        {
            this.transform.position += new Vector3(25.0f * Time.deltaTime, 0.0f, 0.0f);
        }

        this.GetComponent<Animator>().SetInteger("StateInt", 1);

        if (refCamera.transform.position.x - 20.0f > this.transform.position.x || refCamera.transform.position.x + 20.0f < this.transform.position.x)
        {
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Attack")
        {
            if (leftFlag)
            {
                leftFlag = false;
                refObj.GetComponent<PlayerScript>().score += 500;
                col.gameObject.tag = "Untagged";
            }
        }

        if (col.gameObject.tag == "Player")
        {
            if (!oneTimeFlag)
            {
                refObj.GetComponent<PlayerScript>().HP -= 1;
                oneTimeFlag = true;
                refObj.GetComponent<PlayerScript>().blinkingFlag = true;

                Destroy(gameObject);
            }
        }

        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<BossDScript>().HP -= 1;
            refObj.GetComponent<PlayerScript>().score += 500;
            Destroy(gameObject);
        }
    }
}
