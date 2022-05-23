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
    private bool oneTimeFlag2 = false;

    private float start = 8.0f;
    public float StopPos = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        refObjp = GameObject.Find("Player");

        firstPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (refObjp.GetComponent<PlayerScript>().deadFlag) { return; }

        if (refObjp.transform.position.x > start && refObjp.transform.position.x < refObjp.GetComponent<PlayerScript>().MoveLimit - StopPos && refObjp.GetComponent<PlayerScript>().startFlag)
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
