using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScript : MonoBehaviour
{
    private GameObject refObjp;
    public float MoveAmount = 10.0f;
    public GameObject NextBG;

    private Vector3 firstPos;

    private bool oneTimeFlag = false;
    [System.NonSerialized] public bool oneTimeFlag2 = false;

    private float start = 8.0f;
    public float StopPos = 12.0f;

    private int temp = 0;
    private bool posFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        refObjp = GameObject.Find("Player");

        firstPos = this.transform.position;

        temp = refObjp.GetComponent<LastStageManagerScript>().loopNum;

    }

    // Update is called once per frame
    void Update()
    {
        if (refObjp.GetComponent<PlayerScript>().deadFlag) { return; }
        if (refObjp.GetComponent<PlayerScript>().loopFlag && refObjp.GetComponent<PlayerScript>().goalFlag) { return; }
        if(refObjp.GetComponent<PlayerScript>().lastStageFlag)
        {
            if(temp != refObjp.GetComponent<LastStageManagerScript>().loopNum)
            {
                temp = refObjp.GetComponent<LastStageManagerScript>().loopNum;

                if (!oneTimeFlag2)
                {
                    float tempI = this.transform.position.x - refObjp.transform.position.x;

                    this.transform.position = new Vector3(0.0f + tempI, firstPos.y, 0.0f);

                    GameObject A = Instantiate(NextBG, this.transform.position + (new Vector3(gameObject.GetComponent<Renderer>().bounds.size.x, 0.0f, 0.0f) * 2.0f), Quaternion.identity);

                    A.GetComponent<BackGroundScript>().oneTimeFlag2 = true;

                    oneTimeFlag2 = true;
                }
                else
                {
                    float tempI = this.transform.position.x - refObjp.transform.position.x;
                    if(posFlag)
                    {
                        this.transform.position = new Vector3(0.0f + tempI + gameObject.GetComponent<Renderer>().bounds.size.x, firstPos.y, 0.0f);
                        posFlag = false;
                    }
                    else
                    {
                        this.transform.position = new Vector3(0.0f + tempI + gameObject.GetComponent<Renderer>().bounds.size.x * 2.0f, firstPos.y, 0.0f);
                        posFlag = true;
                    }
                }
            }

            if (refObjp.GetComponent<LastStageManagerScript>().loopNum >= 0)
            {
                return;
            }
        }

        if (refObjp.transform.position.x > start && refObjp.transform.position.x < refObjp.GetComponent<PlayerScript>().MoveLimit - StopPos && refObjp.GetComponent<PlayerScript>().startFlag && !refObjp.GetComponent<PlayerScript>().lastStageFlag)
        {
            this.transform.position += new Vector3(MoveAmount * Time.deltaTime, 0.0f, 0.0f);
        }

        if(refObjp.transform.position.x > this.transform.position.x && !oneTimeFlag)
        {
            GameObject A = Instantiate(NextBG, this.transform.position + new Vector3(gameObject.GetComponent<Renderer>().bounds.size.x, 0.0f, 0.0f), Quaternion.identity);

            oneTimeFlag = true;
        }

        if(refObjp.transform.position.x > this.transform.position.x + gameObject.GetComponent<Renderer>().bounds.size.x)
        {
            Destroy(gameObject);
        }

        if (refObjp.GetComponent<PlayerScript>().loopBackFlag)
        {
            if (!oneTimeFlag2)
            {
                float temp = this.transform.position.x - refObjp.transform.position.x;

                this.transform.position = new Vector3(0.0f + temp, firstPos.y, 0.0f);

                oneTimeFlag2 = true;
            }
        }
    }
}
