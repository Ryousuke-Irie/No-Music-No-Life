using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCScript : MonoBehaviour
{
    [System.NonSerialized] public int HP = 55;
    private int tempHP = 55;
    private GameObject refObj;
    private bool oneTimeFlag = false;

    private float heartSpace = 1.5f;
    private float heartToEnemy = 5.0f;

    private static int HEART_MAX = 55;
    GameObject[] cloneHeart = new GameObject[HEART_MAX];

    private float blinkingTime = 0.0f;
    private int blinkingMax = 2;
    private int blinkingNum = 0;

    private bool blinkingFlag = false;
    private bool blinkingFlag2 = false;

    private bool shakeFlag = false;
    private float shakeAmount = 0.0f;

    private float error = 1.0f;

    private int num = 0;

    [SerializeField] GameObject Slush;
    [SerializeField] GameObject cloneSlushAir;

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

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        tempHP = HP;

        cloneSlushAir = Instantiate(Slush, new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f), Quaternion.identity);
        cloneSlushAir.gameObject.SetActive(false);
        cloneSlushAir.GetComponent<BossSlushScript>().velX = 0.0f;

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
            this.transform.position -= new Vector3(7.0f * Time.deltaTime, 0.0f, 0.0f);
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
        }

        if (myTime > 21.15f) // 30
        {
            num += 1;
            myTime = 0.0f;
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
        }

        if (refObj.GetComponent<PlayerScript>().startFlag)
        {
            myTime += Time.deltaTime;
        }

        // 0.7間隔  斬撃 0.0 突進 0.3

        if (myTime > 1.1f && !skill1) // 0 ループはじめだけ通る
        {            
            skill1 = true;
            myTime = 0.0f;
            shakeFlag = true;
        }

        cloneSlushAir.transform.position = new Vector3(this.transform.position.x + -6.0f, 0.0f, 0.0f);

        if (myTime > 0.3f && !skill2 && skill1)
        {
            cloneSlushAir.gameObject.SetActive(true);
            cloneSlushAir.transform.position = new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f);
        }

        if (myTime > 0.7f && !skill2 && skill1) // 1
        {
            cloneSlushAir.gameObject.SetActive(false);
            GameObject cloneSlush = Instantiate(Slush,new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f), Quaternion.identity);

            skill2 = true;
            shakeFlag = true;
        }

        if (myTime > 1.0f && !skill3)
        {
            cloneSlushAir.gameObject.SetActive(true);
            cloneSlushAir.transform.position = new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f);
        }

        if (myTime > 1.4f && !skill3) // 2
        {
            cloneSlushAir.gameObject.SetActive(false);
            GameObject cloneSlush = Instantiate(Slush, new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f), Quaternion.identity);

            skill3 = true;
            shakeFlag = true;
        }


        if (myTime > 2.55f && !skill4) // 4
        {
            moveFlag = true;
            skill4 = true;
        }



        if (myTime > 3.95f && !skill5) // 6
        {
            moveFlag = true;
            skill5 = true;
        }

        if (myTime > 5.9f && !skill6)
        {
            cloneSlushAir.gameObject.SetActive(true);
            cloneSlushAir.transform.position = new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f);
        }

        if (myTime > 6.3f && !skill6) // 9
        {
            cloneSlushAir.gameObject.SetActive(false);
            GameObject cloneSlush = Instantiate(Slush, new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f), Quaternion.identity);

            skill6 = true;
            shakeFlag = true;
        }

        if (myTime > 6.6f && !skill7)
        {
            cloneSlushAir.gameObject.SetActive(true);
            cloneSlushAir.transform.position = new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f);
        }

        if (myTime > 7.0f && !skill7) // 10
        {
            cloneSlushAir.gameObject.SetActive(false);
            GameObject cloneSlush = Instantiate(Slush, new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f), Quaternion.identity);

            skill7 = true;
            shakeFlag = true;
        }

        if (myTime > 7.45f && !skill8) // 11
        {
            moveFlag = true;
            skill8 = true;
        }

        if (myTime > 8.7f && !skill9)
        {
            cloneSlushAir.gameObject.SetActive(true);
            cloneSlushAir.transform.position = new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f);
        }

        if (myTime > 9.1f && !skill9) // 13
        {
            cloneSlushAir.gameObject.SetActive(false);
            GameObject cloneSlush = Instantiate(Slush, new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f), Quaternion.identity);

            skill9 = true;
            shakeFlag = true;
        }

        if (myTime > 10.1f && !skill10)
        {
            cloneSlushAir.gameObject.SetActive(true);
            cloneSlushAir.transform.position = new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f);
        }

        if (myTime > 10.5f && !skill10) // 15
        {
            cloneSlushAir.gameObject.SetActive(false);
            GameObject cloneSlush = Instantiate(Slush, new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f), Quaternion.identity);

            skill10 = true;
            shakeFlag = true;
        }

        if (myTime > 11.2f && !skill11) // 16
        {
            GameObject Obstacle = (GameObject)Resources.Load("Block_train2");
            GameObject Obstacle2 = (GameObject)Resources.Load("Block_train1");
            GameObject Obstacle3 = (GameObject)Resources.Load("Block_train3");

            GameObject cloneObstacle = Instantiate(Obstacle2, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle2 = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle3 = Instantiate(Obstacle, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            skill11 = true;
            shakeFlag = true;
        }

        if (myTime > 11.9f && !skill16) // 17
        {
            moveFlag = true;
            skill16 = true;
        }


        if (myTime > 13.3f && !skill12) // 19
        {
            GameObject Obstacle = (GameObject)Resources.Load("Block_train6");
            GameObject Obstacle2 = (GameObject)Resources.Load("Block_train4");
            GameObject Obstacle3 = (GameObject)Resources.Load("Block_train5");

            GameObject cloneObstacle = Instantiate(Obstacle2, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle2 = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle3 = Instantiate(Obstacle, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            moveFlag = true;
            skill12 = true;
            shakeFlag = true;
        }

        if (myTime > 14.7f && !skill17) // 21
        {
            //GameObject cloneSlush = Instantiate(Slush, new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f), Quaternion.identity);

            skill17 = true;
            shakeFlag = true;
        }

        if (myTime > 16.1f && !skill13) // 23
        {
            GameObject Obstacle = (GameObject)Resources.Load("Block_train9");

            GameObject cloneObstacle = Instantiate(Obstacle, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            skill13 = true;
            shakeFlag = true;
        }

        if (myTime > 16.8f && !skill14 && num < 2) // 24
        {
            //GameObject cloneSlush = Instantiate(Slush, new Vector3(this.transform.position.x + -6.0f, refObj.transform.position.y, 0.0f), Quaternion.identity);

            GameObject Obstacle2 = (GameObject)Resources.Load("Block_train7");
            GameObject Obstacle3 = (GameObject)Resources.Load("Block_train8");

            GameObject cloneObstacle = Instantiate(Obstacle2, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle2 = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);

            skill14 = true;
            shakeFlag = true;
        }

        if (myTime > 18.2f && !skill15 && num < 2) // 26
        {
            GameObject Obstacle2 = (GameObject)Resources.Load("Block_train10");
            GameObject Obstacle3 = (GameObject)Resources.Load("Block_train11");

            GameObject cloneObstacle = Instantiate(Obstacle2, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle2 = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);

            skill15 = true;
            shakeFlag = true;
        }

        if (myTime > 18.9f && !skill19) // 27
        {
            moveFlag = true;
            skill19 = true;
        }


        if (HP <= 0)
        {
            Destroy(gameObject);

            refObj.GetComponent<PlayerScript>().score +=2000;

            refObj.GetComponent<PlayerScript>().goalFlag = true;
            Cursor.visible = true;
        }

        if (tempHP > HP)
        {
            tempHP = HP;
            
            blinkingFlag = true;
        }

        // HP(ハート)を設置
        for (int i = 0; i < 5; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + (i * heartSpace) - space - error, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(255, 180, 70, 255);
            }
        }

        for (int i = 5; i < 10; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 5) * heartSpace) - space - error, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(255, 255, 40, 255);
            }
        }

        for (int i = 10; i < 15; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 10) * heartSpace) - space - error, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(180, 255, 40, 255);
            }
        }

        for (int i = 15; i < 20; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 15) * heartSpace) - space - error, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(20, 255, 40, 255);
            }
        }

        for (int i = 20; i < 25; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 20) * heartSpace) - space - error, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(20, 255, 200, 255);
            }
        }

        for (int i = 25; i < 30; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 25) * heartSpace) - space - error, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(20, 200, 255, 255);
            }
        }

        for (int i = 30; i < 35; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 30) * heartSpace) - space - error, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(20, 120, 255, 255);
            }
        }

        for (int i = 35; i < 40; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 35) * heartSpace) - space - error, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(90, 0, 230, 255);
            }
        }

        for (int i = 40; i < 45; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 40) * heartSpace) - space - error, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(200, 0, 230, 255);
            }
        }

        for (int i = 45; i < 50; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 45) * heartSpace) - space - error, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(255, 0, 150, 255);
            }
        }

        for (int i = 50; i < 55; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 50) * heartSpace) - space - error, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(220, 0, 60, 255);
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
            HP -= 2;
            moveFlag = false;
            refObj.GetComponent<PlayerScript>().score += 1500;
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
