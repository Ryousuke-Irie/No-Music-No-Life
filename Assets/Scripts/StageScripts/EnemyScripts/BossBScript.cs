using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBScript : MonoBehaviour
{
    [System.NonSerialized] public int HP = 40;
    private int tempHP = 40;
    private GameObject refObj;
    private bool oneTimeFlag = false;

    private float heartSpace = 1.5f;
    private float heartToEnemy = 5.0f;

    private static int HEART_MAX = 40;
    GameObject[] cloneHeart = new GameObject[HEART_MAX];

    private float blinkingTime = 0.0f;
    private int blinkingMax = 2;
    private int blinkingNum = 0;

    private bool blinkingFlag = false;
    private bool blinkingFlag2 = false;

    private bool shakeFlag = false;
    private float shakeAmount = 0.0f;

    private bool moveFlag = false;
    private float myTime = 0.0f;
    private bool skill1 = false;
    private bool skill2 = false;
    private bool skill3 = false;
    private bool skill4 = false;
    private bool skill5 = false;
    private bool skill6 = false;
    private bool skill7 = false;
    private bool skill8 = false;

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

    void FixedUpdate()
    {
        // 点滅処理
        Blinking();

        // 上下の揺れ
        if (shakeFlag && shakeAmount < 0.4f)
        {
            this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.0f);
            shakeAmount += 0.1f;
        }

        if (shakeFlag && shakeAmount >= 0.4f && shakeAmount < 0.8f)
        {
            this.transform.localScale += new Vector3(0.1f, 0.1f, 0.0f);
            shakeAmount += 0.1f;
        }

        if (shakeFlag && shakeAmount >= 0.8f)
        {
            shakeFlag = false;
            shakeAmount = 0.0f;
            this.transform.localScale = new Vector3(2.0f, 2.0f, 1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!moveFlag)
        {
            this.transform.position = new Vector3(refObj.transform.position.x + 18.0f, -2.0f, 0.0f);
        }
        else
        {
            this.transform.position -= new Vector3(2.0f * Time.deltaTime, 0.0f, 0.0f);
        }

        // アクション
        if (refObj.GetComponent<PlayerScript>().loopBossFlag)
        {
            refObj.GetComponent<PlayerScript>().loopBossFlag = false;
            myTime = 0.0f;
            skill1 = false;
            skill2 = false;
            skill3 = false;
            skill4 = false;
            skill5 = false;
            skill6 = false;
            skill7 = false;
            skill8 = false;
        }

        if (refObj.GetComponent<PlayerScript>().startFlag)
        {
            myTime += Time.deltaTime;
        }



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
            blinkingFlag = true;
        }

        // HP(ハート)を設置
        for (int i = 0; i < 5; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + (i * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(255, 180, 70, 255);
            }
        }

        for (int i = 5; i < 10; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 5) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(255, 255, 40, 255);
            }
        }

        for (int i = 10; i < 15; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 10) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(180, 255, 40, 255);
            }
        }

        for (int i = 15; i < 20; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 15) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(20, 255, 40, 255);
            }
        }

        for (int i = 20; i < 25; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 20) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(20, 255, 200, 255);
            }
        }

        for (int i = 25; i < 30; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 25) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(20, 200, 255, 255);
            }
        }

        for (int i = 30; i < 35; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 30) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(20, 120, 255, 255);
            }
        }

        for (int i = 35; i < 40; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 35) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(90, 0, 230, 255);
            }
        }

        if (HP < 0)
        {
            HP = 0;
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
            moveFlag = false;
            col.gameObject.tag = "Untagged";
        }

        if (col.gameObject.tag == "Player")
        {
            refObj.GetComponent<PlayerScript>().HP -= 1;
            refObj.GetComponent<PlayerScript>().blinkingFlag = true;
            moveFlag = false;
        }
    }

    private void Blinking()
    {
        // 点滅
        if (blinkingFlag)
        {
            blinkingNum = blinkingMax;
            blinkingFlag = false;
        }

        if (blinkingNum > 0 && !blinkingFlag2)
        {
            blinkingFlag2 = true;
            blinkingNum -= 1;
        }

        if (blinkingFlag2)
        {
            this.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);

            blinkingTime += 0.1f;

            if (blinkingTime > 1.0f)
            {
                this.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                blinkingTime = 0.0f;
                blinkingFlag2 = false;
            }
        }
    }
}
