using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectScoreScript : MonoBehaviour
{
    GameObject refObj;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("score");
    }

    // Update is called once per frame
    void Update()
    {
        if (refObj.GetComponent<ScoreController>().deleteFlag)
        {
            Destroy(gameObject);
        }
    }
}
