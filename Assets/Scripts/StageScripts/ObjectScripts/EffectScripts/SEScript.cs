using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!this.GetComponent<AudioSource>().isPlaying)
        {
            Destroy(gameObject, 0.0f);
        }
    }
}
