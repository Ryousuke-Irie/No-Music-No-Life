using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forDebugScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameObject enemy = (GameObject)Resources.Load("Enemy");
            GameObject cloneEnemy = Instantiate(enemy, new Vector3(4.56f, -1.51f, 0.0f), Quaternion.identity);
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
