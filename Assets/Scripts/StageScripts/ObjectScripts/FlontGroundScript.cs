using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlontGroundScript : MonoBehaviour
{
    private GameObject refObjp;
    public GameObject flontBG;

    private bool oneTimeFlag = false;

    public float nextPos = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        refObjp = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (refObjp.transform.position.x > this.transform.position.x && !oneTimeFlag)
        {
            GameObject A = Instantiate(flontBG, this.transform.position + new Vector3(nextPos, 0.0f, 0.0f), Quaternion.identity);

            oneTimeFlag = true;
        }

        if (refObjp.transform.position.x > this.transform.position.x + nextPos)
        {
            Destroy(gameObject);
        }
    }
}
