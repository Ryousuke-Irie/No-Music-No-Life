using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickScript : MonoBehaviour
{
    private GameObject refObj;
    private PlayerScript playerScript;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        playerScript = refObj.GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScript.loopStageFlag)
        {
            Destroy(gameObject);
        }
    }
}
