using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int HP = 5;

    public float InitialPower = 1.0f;
    public float Power = 1.0f;

    public float TempoTime = 0.0f;

    public bool isRight = true;

    public bool isDamaged = false;

    public bool isAttacked = false;

    public bool intervalFlag = false;

    public float Green = 255;
    public float Blue = 255;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (this.transform.position.y < -10.0f)
        {
            HP = 0;
        }
    }
}
