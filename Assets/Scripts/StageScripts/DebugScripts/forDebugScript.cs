using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forDebugScript : MonoBehaviour
{
    GameObject refObj;
    GameObject refObj2;

    private bool oneTimeFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        refObj2 = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //if(refObj.transform.position.x > 140.0f && !oneTimeFlag)
        //{
        //    oneTimeFlag = true;
        //    GameObject gool = (GameObject)Resources.Load("Goal");
        //    GameObject cloneGool = Instantiate(gool, new Vector3(refObj2.transform.position.x, refObj2.transform.position.y, 0.0f), Quaternion.identity);
        //}

        //if ((Input.GetKeyDown(KeyCode.R)) || (refObj.GetComponent<PlayerStatus>().HP <= 0))
        //{
        //    SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        //}

        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
#endif
        }
    }
}
