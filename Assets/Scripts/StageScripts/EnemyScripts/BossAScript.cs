using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAScript : MonoBehaviour
{
    private int HP = 40;
    private int tempHP = 40;
    private GameObject refObj;
    private bool oneTimeFlag = false;

    private float heartSpace = 1.5f;
    private float heartToEnemy = 5.0f;

    private static int HEART_MAX = 40;
    GameObject[] cloneHeart = new GameObject[HEART_MAX];

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        tempHP = HP;

        for (int i = 0; i < HEART_MAX; i++)
        {
            if (cloneHeart[i] == null)
            {
                GameObject Heart = (GameObject)Resources.Load("heart");
                cloneHeart[i] = Instantiate(Heart, new Vector3(this.transform.position.x + (i * heartSpace), this.transform.position.y + heartToEnemy, 0.0f), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = refObj.transform.position + new Vector3(6.0f, 0.0f, 0.0f);

        if (HP <= 0)
        {
            Destroy(gameObject);

            refObj.GetComponent<PlayerScript>().score += 500;

            refObj.GetComponent<PlayerScript>().goalFlag = true;
            Cursor.visible = true;
        }

        if (tempHP > HP)
        {
            tempHP = HP;
            refObj.GetComponent<PlayerScript>().score += 500;
        }

        // HP(ハート)を設置
        for (int i = 0; i < 5; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + (i * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);
            }
        }

        for (int i = 5; i < 10; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 5) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(0, 255, 0, 255);
            }
        }

        for (int i = 10; i < 15; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 10) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(255, 140, 255, 255);
            }
        }

        for (int i = 15; i < 20; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 15) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(140, 255, 255, 255);
            }
        }

        for (int i = 20; i < 25; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 20) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(255, 70, 255, 255);
            }
        }

        for (int i = 25; i < 30; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i -25) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(70, 255, 255, 255);
            }
        }

        for (int i = 30; i < 35; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 30) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(255, 0, 255, 255);
            }
        }

        for (int i = 35; i < 40; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 35) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(0, 255, 255, 255);
            }
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
