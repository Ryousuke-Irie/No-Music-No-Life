using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberScript : MonoBehaviour
{
    private GameObject refObj;
    private GameObject refObj2;
    [System.NonSerialized] public float pos_x = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        refObj2 = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(refObj2.transform.position.x + pos_x, this.transform.position.y, this.transform.position.z);

        if (refObj.GetComponent<ScoreScript>().deleteFlag)
        {
            Destroy(gameObject);
        }
    }
}
