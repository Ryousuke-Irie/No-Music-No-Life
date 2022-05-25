using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDScript : MonoBehaviour
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
    private bool skill9 = false;
    private bool skill10 = false;
    private bool skill11 = false;
    private bool skill12 = false;
    private bool skill13 = false;
    private bool skill14 = false;
    private bool skill15 = false;
    private bool skill16 = false;
    private bool skill17 = false;
    private bool skill18 = false;
    private bool skill19 = false;
    private bool skill20 = false;
    private bool skill21 = false;
    private bool skill22 = false;
    private bool skill23 = false;
    private bool skill24 = false;
    private bool skill25 = false;
    private bool skill26 = false;
    private bool skill27 = false;
    private bool skill28 = false;
    private bool skill29 = false;
    private bool skill30 = false;

    GameObject refCircle;
    GameObject refTriangle;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        tempHP = HP;
        refCircle = (GameObject)Resources.Load("CircleBom");
        refTriangle = (GameObject)Resources.Load("TriangleBom");

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
            this.transform.position -= new Vector3(4.0f * Time.deltaTime, 0.0f, 0.0f);
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
            skill9 = false;
            skill10 = false;
            skill11 = false;
            skill12 = false;
            skill13 = false;
            skill14 = false;
            skill15 = false;
            skill16 = false;
            skill17 = false;
            skill18 = false;
            skill19 = false;
            skill20 = false;
            skill21 = false;
            skill22 = false;
            skill23 = false;
            skill24 = false;
            skill25 = false;
            skill26 = false;
            skill27 = false;
            skill28 = false;
            skill29 = false;
            skill30 = false;
        }

        if (refObj.GetComponent<PlayerScript>().startFlag)
        {
            myTime += Time.deltaTime;
        }

        if (refObj.GetComponent<LastStageManagerScript>().loopNum == -1)
        {
            PatternA();
        }

        if (refObj.GetComponent<LastStageManagerScript>().loopNum == 0 || refObj.GetComponent<LastStageManagerScript>().loopNum == 2)
        {
            PatternB1();
        }

        if (refObj.GetComponent<LastStageManagerScript>().loopNum == 1)
        {
            PatternB2();
        }

        if (refObj.GetComponent<LastStageManagerScript>().loopNum == 3)
        {
            PatternB4();
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
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 25) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

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

    private void PatternA()
    {
        if (myTime > 1.4f && !skill12)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity); 
            skill12 = true;
        }

        if (myTime > 3.1f && !skill1)
        {
            moveFlag = true;
            skill1 = true;
        }

        if (myTime > 4.3f && !skill15)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill15 = true;
        }

        if (myTime > 6.3f && !skill2)
        {
            GameObject cloneApple = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill2 = true;
        }

        if (myTime > 7.1f && !skill4)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill4 = true;
        }

        if (myTime > 9.1f && !skill3)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill3 = true;
        }

        if (myTime > 11.1f && !skill5)
        {
            moveFlag = true;
            skill5 = true;
        }

        if (myTime > 14.1f && !skill6)
        {
            moveFlag = true;
            skill6 = true;
        }

        if (myTime > 16.1f && !skill7)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill7 = true;
        }

        if (myTime > 17.4f && !skill8)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill8 = true;
        }

        if (myTime > 18.2f && !skill9)
        {
            GameObject cloneApple = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill9 = true;
        }

        if (myTime > 19.4f && !skill10)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill10 = true;
        }

        if (myTime > 21.4f && !skill11)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill11 = true;
        }

        if (myTime > 21.8f && !skill13)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity);
            skill13 = true;
        }

        if (myTime > 22.4f && !skill14)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple3 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill14 = true;
        }

        if (myTime > 23.9f && !skill16)
        {
            GameObject cloneApple = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill16 = true;
        }

        if (myTime > 25.1f && !skill17)
        {
            GameObject cloneApple = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill17 = true;
        }

        if (myTime > 26.7f && !skill18)
        {
            moveFlag = true;
            skill18 = true;
        }

        if (myTime > 29.4f && !skill19)
        {
            GameObject cloneApple = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple3 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill19 = true;
        }

        if (myTime > 30.1f && !skill20)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill20 = true;
        }

        if (myTime > 30.9f && !skill21)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity);
            skill21 = true;
        }

        if (myTime > 31.3f && !skill22)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill22 = true;
        }

        if (myTime > 31.9f && !skill23)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill23 = true;
        }

        if (myTime > 32.5f && !skill24)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill24 = true;
        }

        if (myTime > 34.4f && !skill25)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple3 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill25 = true;
        }

        if (myTime > 35.1f && !skill26)
        {
            moveFlag = true;
            skill26 = true;
        }

        if (myTime > 36.1f && !skill27)
        {
            GameObject cloneApple = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill27 = true;
        }

        if (myTime > 37.4f && !skill28)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple3 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill28 = true;
        }

        if (myTime > 38.1f && !skill29)
        {
            moveFlag = true;
            skill29 = true;
        }

        if (myTime > 40.1f && !skill30)
        {
            moveFlag = true;
            skill30 = true;
        }
    }

    private void PatternB1()
    {
        if (myTime > 1.1f && !skill1)
        {
            GameObject cloneApple = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill1 = true;
        }


        if (myTime > 2.1f && !skill2)
        {
            moveFlag = true;
            skill2 = true;
        }


        if (myTime > 3.1f && !skill3)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill3 = true;
        }


        if (myTime > 4.1f && !skill4)
        {
            moveFlag = true;
            skill4 = true;
        }


        if (myTime > 5.1f && !skill4)
        {
            GameObject cloneApple = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill4 = true;
        }

        if (myTime > 7.1f && !skill5)
        {
            moveFlag = true;
            skill5 = true;
        }

        if (myTime > 9.1f && !skill6)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity);
            GameObject cloneApple2 = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill6 = true;
        }
    }

    private void PatternB2()
    {
        if (myTime > 1.1f && !skill1)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill1 = true;
        }


        if (myTime > 2.1f && !skill2)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity);
            skill2 = true;
        }


        if (myTime > 3.1f && !skill3)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill3 = true;
        }


        if (myTime > 4.1f && !skill4)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity);
            skill4 = true;
        }


        if (myTime > 5.1f && !skill4)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill4 = true;
        }

        if (myTime > 7.1f && !skill5)
        {
            moveFlag = true;
            skill5 = true;
        }

        if (myTime > 9.1f && !skill6)
        {
            GameObject cloneApple = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill6 = true;
        }
    }

    private void PatternB4()
    {
        if (myTime > 1.1f && !skill1)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill1 = true;
        }


        if (myTime > 2.1f && !skill2)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity);
            skill2 = true;
        }


        if (myTime > 3.1f && !skill3)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill3 = true;
        }


        if (myTime > 4.1f && !skill4)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity);
            skill4 = true;
        }


        if (myTime > 5.1f && !skill4)
        {
            GameObject cloneApple = Instantiate(refTriangle, this.transform.position + new Vector3(-6.0f, -4.0f, 0.0f), Quaternion.identity);
            skill4 = true;
        }

        if (myTime > 7.1f && !skill5)
        {
            moveFlag = true;
            skill5 = true;
        }

        if (myTime > 9.1f && !skill6)
        {
            GameObject cloneApple = Instantiate(refCircle, this.transform.position + new Vector3(-6.0f, 0.0f, 0.0f), Quaternion.identity);
            skill6 = true;
        }
    }
}
