using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackA : MonoBehaviour
{
    public float CoolTime = 2.0f;
    [Header("ã‚ª‚é‚Ù‚Ç’Z‚­‚È‚é")] public float StandByTime = 200.0f;
    public bool Attack = false;
    public float EnemyToSlush = 3.5f;
    public float EnemyToPlayer = 6.1f;

    private float myTime = 0.0f;
    private float returnTime = 0.0f;

    private float Alpha = 255.0f;

    GameObject refObj;
    GameObject cloneExMark;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Attack)
        {
            if (cloneExMark == null)
            {
                if (this.transform.position.x > refObj.transform.position.x)
                {
                    if (this.GetComponent<EnemyMove>().rightTleftF)
                    {
                        returnTime += Time.deltaTime;

                        if (returnTime > CoolTime + 0.5f)
                        {
                            returnTime = 0.0f;
                            this.transform.position += new Vector3(0.0f, 0.5f, 0.0f);
                            this.GetComponent<EnemyMove>().rightTleftF = false;
                            transform.localScale = new Vector3(-1 * transform.localScale.x, 1 * transform.localScale.y, 1);
                        }
                    }
                    else
                    {
                        returnTime = 0.0f;
                    }
                }
                else
                {
                    if (!this.GetComponent<EnemyMove>().rightTleftF)
                    {
                        returnTime += Time.deltaTime;

                        if (returnTime > CoolTime + 0.5f)
                        {
                            returnTime = 0.0f;
                            this.transform.position += new Vector3(0.0f, 0.5f, 0.0f);
                            this.GetComponent<EnemyMove>().rightTleftF = true;
                            transform.localScale = new Vector3(-1 * transform.localScale.x, 1 * transform.localScale.y, 1);
                        }
                    }
                    else
                    {
                        returnTime = 0.0f;
                    }
                }

                if (this.transform.position.x - refObj.transform.position.x < EnemyToPlayer + 5.0f)
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

                float dist = this.transform.position.x - refObj.transform.position.x;

                if (dist < 0.0f)
                {
                    dist *= -1;
                }

                if ((this.transform.position.x > refObj.transform.position.x && !this.GetComponent<EnemyMove>().rightTleftF) || (this.transform.position.x < refObj.transform.position.x && this.GetComponent<EnemyMove>().rightTleftF))
                {
                    if (dist < EnemyToPlayer && myTime >= CoolTime)
                    {
                        myTime = 0.0f;

                        Alpha = 255.0f;

                        GameObject ExMark = (GameObject)Resources.Load("ExclamationMark");
                        cloneExMark = Instantiate(ExMark, this.transform.position + new Vector3(0.0f, this.GetComponent<EnemyScript>().EnemyToBar + 1.0f, 0.0f), Quaternion.identity);
                    }
                }
            }

            if (cloneExMark)
            {
                if (Alpha > 0.0f)
                {
                    Alpha -= Time.deltaTime * StandByTime;
                    cloneExMark.transform.position = this.transform.position + new Vector3(0.0f, this.GetComponent<EnemyScript>().EnemyToBar + 1.0f, 0.0f);
                    cloneExMark.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, (byte)Alpha);
                }

                if (Alpha <= 0.0f)
                {
                    Destroy(cloneExMark);

                    if (this.GetComponent<EnemyMove>().rightTleftF)
                    {
                        GameObject Slush = (GameObject)Resources.Load("EnemySlush");
                        GameObject cloneSlush = Instantiate(Slush, this.transform.position + new Vector3(EnemyToSlush, 0.0f, 0.0f), Quaternion.identity);
                    }
                    else
                    {
                        GameObject Slush = (GameObject)Resources.Load("EnemySlushLeft");
                        GameObject cloneSlush = Instantiate(Slush, this.transform.position + new Vector3(-EnemyToSlush, 0.0f, 0.0f), Quaternion.identity);
                    }
                }
            }
        }
    }

    void OnDestroy()
    {
        if (cloneExMark)
        {
            Destroy(cloneExMark);
        }
    }
}
