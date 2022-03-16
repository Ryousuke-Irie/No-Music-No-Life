using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public float HP = 10.0f;
    public float MaxHP = 10.0f;

    public float EnemyToBar = 3.0f;

    private bool damageFlag = false;
    private bool damageFlag2 = false;

    private float time = 0;

    GameObject refObj;
    PlayerStatus playerStatus;

    GameObject cloneBar;
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        playerStatus = refObj.GetComponent<PlayerStatus>();
        GameObject bar = (GameObject)Resources.Load("EnemyHPbar");
        cloneBar = Instantiate(bar, this.transform.position + new Vector3(0.0f, EnemyToBar, 0.0f), Quaternion.identity);
        slider = cloneBar.GetComponentInChildren<Slider>();
        slider.maxValue = HP;
        slider.value = HP;
    }

    // Update is called once per frame
    void Update()
    {
        cloneBar.transform.position = this.transform.position + new Vector3(0.0f, EnemyToBar, 0.0f);

        if (HP <= 0.0f)
        {
            Destroy(gameObject, 0.0f);
            Destroy(cloneBar);
        }

        if(!damageFlag && damageFlag2)
        {
            if (time < 0.0f)
            {
                time = 0.0f;
                damageFlag2 = false;
                this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            else 
            {
                this.transform.localScale += new Vector3(0.01f, 0.01f, 0.0f);
                time -= Time.deltaTime;
            }
        }

        if (damageFlag)
        {
            if(time > 0.02f)
            {
                time = 0.02f;
                damageFlag = false;
                damageFlag2 = true;
            }
            else
            {
                this.transform.localScale += new Vector3(-0.01f, -0.01f, 0.0f);
                time += Time.deltaTime;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Attack")
        {
            HP -= playerStatus.Power;
            slider.value = HP; 
            damageFlag = true;

            col.gameObject.tag = "Untagged";
        }

        if (col.gameObject.tag == "Zangeki")
        {
            HP -= col.GetComponent<ZangekiScript>().Power;
            slider.value = HP;
            damageFlag = true;

            col.gameObject.tag = "Untagged";
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (!refObj.GetComponent<PlayerStatus>().isDamaged)
            {
                refObj.GetComponent<PlayerStatus>().HP -= 1;

                refObj.GetComponent<PlayerStatus>().isDamaged = true;

                refObj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

                if (refObj.transform.position.x < this.transform.position.x)
                {
                    refObj.GetComponent<Rigidbody2D>().AddForce(new Vector2(-300.0f, 500.0f));
                }
                else
                {
                    refObj.GetComponent<Rigidbody2D>().AddForce(new Vector2(300.0f, 500.0f));
                }
            }
        }
    }
}
