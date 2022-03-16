using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forDebugScript : MonoBehaviour
{
    GameObject refObj;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.R)) || (refObj.GetComponent<PlayerStatus>().HP <= 0))
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
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
