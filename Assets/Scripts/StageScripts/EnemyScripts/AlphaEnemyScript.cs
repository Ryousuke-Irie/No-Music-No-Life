using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaEnemyScript : MonoBehaviour
{
    public int HP = 1;
    private int tempHP = 1;
    private GameObject refObj;
    private bool oneTimeFlag = false;

    private GameObject refCamera;

    private float heartSpace = 1.5f;
    private float heartToEnemy = 2.0f;

    private static int HEART_MAX = 5;
    GameObject[] cloneHeart = new GameObject[HEART_MAX];

    public bool scoreFlag = false;

    private float colorFloat = 0.0f;

    private float nextPosX = 0.0f;
    private float plusAmountAlpha = 120.0f;
    private float plusAmountMove = 10.0f;
    private PlayerScript playerScript;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        refCamera = GameObject.Find("Main Camera");
        tempHP = HP;
        playerScript = refObj.GetComponent<PlayerScript>();

        this.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);

        nextPosX = refObj.GetComponent<PlayerScript>().Next3dist + 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.loopStageFlag)
        {
            Destroy(gameObject);
        }

        if (refCamera.transform.position.x - 20.0f > this.transform.position.x)
        {
            Destroy(gameObject);
        }

        if (HP <= 0)
        {
            Destroy(gameObject);

            if (!scoreFlag)
            {
                refObj.GetComponent<PlayerScript>().score += 500;
            }
        }

        if(refObj.transform.position.x + 13.0f > this.transform.position.x)
        {
            if(this.transform.position.x < nextPosX)
            {
                this.transform.position += new Vector3(plusAmountMove * Time.deltaTime, 0.0f, 0.0f);
            }

            if(this.GetComponent<SpriteRenderer>().color.a < 255)
            {
                colorFloat += plusAmountAlpha * Time.deltaTime;
                if(colorFloat >= 255.0f)
                {
                    colorFloat = 255.0f;
                }

                this.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, (byte)colorFloat);
            }
        }

        if (tempHP > HP)
        {
            tempHP = HP;
            if (!scoreFlag)
            {
                refObj.GetComponent<PlayerScript>().score += 500;
            }
            this.transform.position = new Vector3(refObj.GetComponent<PlayerScript>().Nextdist + 5.0f, this.transform.position.y, this.transform.position.z);
        }

        if (HP < 0)
        {
            HP = 0;
        }

        // HP(?n?[?g)?????u
        for (int i = 0; i < HP; i++)
        {
            float space = heartSpace * 0.5f * (HP - 1);

            if (cloneHeart[i] == null)
            {
                GameObject Heart = (GameObject)Resources.Load("heart");
                cloneHeart[i] = Instantiate(Heart, new Vector3(this.transform.position.x + (i * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f), Quaternion.identity);
                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(255, 170, 70, 0);
            }

            cloneHeart[i].transform.position = new Vector3(this.transform.position.x + (i * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

            cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(255, 170, 70, (byte)colorFloat);
        }

        for (int i = HP; i < HEART_MAX; i++)
        {
            if (cloneHeart[i])
            {
                Destroy(cloneHeart[i]);
            }
        }
    }

    void OnDestroy()
    {
        for (int i = 0; i < HEART_MAX; i++)
        {
            if (cloneHeart[i])
            {
                Destroy(cloneHeart[i]);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Attack")
        {
            HP -= 1;

            col.gameObject.tag = "Untagged";
        }

        if (col.gameObject.tag == "Player")
        {
            if (!oneTimeFlag)
            {
                refObj.GetComponent<PlayerScript>().HP -= 1;
                oneTimeFlag = true;
                refObj.GetComponent<PlayerScript>().blinkingFlag = true;
            }
        }
    }
}
