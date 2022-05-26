using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockScript : MonoBehaviour
{
    GameObject refObj;

    private bool oneTimeFlag = false;
    private PlayerScript playerScript;
    private GameObject refCamera;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        playerScript = refObj.GetComponent<PlayerScript>();
        refCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (refCamera.transform.position.x - 20.0f > this.transform.position.x)
        {
            Destroy(gameObject);
        }

        if (playerScript.loopStageFlag)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene("FirstStageScene", LoadSceneMode.Single);
            if (!oneTimeFlag)
            {
                refObj.GetComponent<PlayerScript>().HP -= 1;
                oneTimeFlag = true;
                refObj.GetComponent<PlayerScript>().blinkingFlag = true;
            }
        }
    }
}
