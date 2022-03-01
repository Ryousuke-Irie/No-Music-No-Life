using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackA : MonoBehaviour
{
    public float CoolTime = 2.0f;

    private float myTime;

    GameObject refObj;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x - refObj.transform.position.x < 10.0f)
        {
            if (myTime > CoolTime)
            {
                myTime = CoolTime;
            }
            else
            {
                myTime += Time.deltaTime;
            }
        }
        else
        {
            myTime = 0.0f;
        }

        if (this.transform.position.x - refObj.transform.position.x < 6.0f && myTime >= CoolTime)
        {
            myTime = 0.0f;

            GameObject Slush = (GameObject)Resources.Load("EnemySlushLeft");
            GameObject cloneSlush = Instantiate(Slush, this.transform.position + new Vector3(-3.0f, 0.0f, 0.0f), Quaternion.identity);
        }
    }
}
