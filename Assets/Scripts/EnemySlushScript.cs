using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlushScript : MonoBehaviour
{
    private ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!ps.isPlaying)
        {
            Destroy(gameObject, 0.0f);
        }
    }
}
