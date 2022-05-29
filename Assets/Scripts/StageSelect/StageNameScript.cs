using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageNameScript : MonoBehaviour
{
    [SerializeField] int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(StageSelectController.barNum == num)
        {
            this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        else
        {
            this.transform.localScale = new Vector3(0.7f, 0.7f, 1.0f);
        }
    }
}
