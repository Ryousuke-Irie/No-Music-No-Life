using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastStageManagerScript : MonoBehaviour
{
    private GameObject cloneLastBossBGM;
    private GameObject refObj;

    [System.NonSerialized] public int loopNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");

        GameObject LastBoss = (GameObject)Resources.Load("BGM_A");
        cloneLastBossBGM = Instantiate(LastBoss, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (refObj.GetComponent<PlayerScript>().loopLastFlag)
        {
            refObj.GetComponent<PlayerScript>().loopLastFlag = false;
            Destroy(cloneLastBossBGM);

            if (loopNum == 0)
            {
                GameObject LastBoss = (GameObject)Resources.Load("BGM_B1");
                cloneLastBossBGM = Instantiate(LastBoss, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                loopNum = 1;
            }
            else if (loopNum == 1)
            {
                GameObject LastBoss = (GameObject)Resources.Load("BGM_B2");
                cloneLastBossBGM = Instantiate(LastBoss, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                loopNum = 2;
            }
            else if (loopNum == 2)
            {
                GameObject LastBoss = (GameObject)Resources.Load("BGM_B3");
                cloneLastBossBGM = Instantiate(LastBoss, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                loopNum = 3;
            }
            else if (loopNum == 3)
            {
                GameObject LastBoss = (GameObject)Resources.Load("BGM_B4");
                cloneLastBossBGM = Instantiate(LastBoss, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                loopNum = 0;
            }
        }
    }
}
