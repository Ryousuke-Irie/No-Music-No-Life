using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlontGroundScript : MonoBehaviour
{
    private GameObject refObjp;
    public GameObject flontBG;

    private Vector3 firstPos;

    private bool oneTimeFlag = false;
    private bool oneTimeFlag2 = false;

    public float nextPos = 0.0f;

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

        if (refObjp.transform.position.x > this.transform.position.x && !oneTimeFlag)
        {
            GameObject A = Instantiate(flontBG, this.transform.position + new Vector3(nextPos, 0.0f, 0.0f), Quaternion.identity);

            oneTimeFlag = true;
        }

        if (refObjp.transform.position.x > this.transform.position.x + nextPos)
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
