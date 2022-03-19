using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [Header("«««‚±‚±‚©‚ç‰º‚Ì•Ï”‚ÍG‚ç‚È‚¢«««")] public int HP = 5;

    public float InitialPower = 1.0f;
    public float Power = 1.0f;

    public float TempoTime = 0.0f;

    public float intervalTime3;

    public bool isRight = true;

    public bool isDamaged = false;

    public bool isAttacked = false;

    public bool intervalFlag = false;

    public bool rotateFlag = false;

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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "EnemyAttack")
        {
            if (!isDamaged)
            {
                HP -= 1;

                isDamaged = true;

                this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

                if (this.transform.position.x < col.transform.position.x)
                {
                    this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-300.0f, 500.0f));
                }
                else
                {
                    this.GetComponent<Rigidbody2D>().AddForce(new Vector2(300.0f, 500.0f));
                }
            }
        }
    }
}
