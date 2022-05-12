using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultNumberScript : MonoBehaviour
{
    private GameObject refObj;
    private bool deleteMode = false;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");

        deleteMode = refObj.GetComponent<ResultScript>().deleteFlag;
    }

    // Update is called once per frame
    void Update()
    {
        if (deleteMode != refObj.GetComponent<ResultScript>().deleteFlag)
        {
            Destroy(gameObject);
        }
    }
}
