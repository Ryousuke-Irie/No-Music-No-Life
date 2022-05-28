using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    private bool shakeFlag = false;
    private float shakeAmount = 0.0f;
    GameObject refObj;
    PlayerScript playerScript;
    private float posX = 9.0f;
    private bool oneTimeFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        playerScript = refObj.GetComponent<PlayerScript>();
    }

    private void FixedUpdate()
    {
        // è„â∫ÇÃóhÇÍ
        if (shakeFlag && shakeAmount < 0.3f)
        {
            this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.0f);
            shakeAmount += 0.1f;
        }

        if (shakeFlag && shakeAmount >= 0.3f && shakeAmount < 0.6f)
        {
            this.transform.localScale += new Vector3(0.1f, 0.1f, 0.0f);
            shakeAmount += 0.1f;
        }

        if (shakeFlag && shakeAmount >= 0.6f)
        {
            shakeFlag = false;
            shakeAmount = 0.0f;
            this.transform.localScale = new Vector3(1.2f, 1.2f, 1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (refObj.transform.position.x > posX)
        {
            posX = playerScript.Nextdist;
            shakeFlag = true;
        }
    }
}
