using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBScript : MonoBehaviour
{
    [System.NonSerialized] public int HP = 50;
    private int tempHP = 50;
    private GameObject refObj;
    private bool oneTimeFlag = false;

    private float heartSpace = 1.5f;
    private float heartToEnemy = 5.0f;

    private static int HEART_MAX = 50;
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
        }

        if (refObj.GetComponent<PlayerScript>().startFlag)
        {
            myTime += Time.deltaTime;
        }


        if (myTime > 1.0f && !skill4)
        {
            GameObject Enemy = (GameObject)Resources.Load("Enemy_B1");
            GameObject cloneEnemy = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy2 = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy3 = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            GameObject Obstacle2 = (GameObject)Resources.Load("Block_center2");
            GameObject Obstacle = (GameObject)Resources.Load("Block_top2");

            GameObject cloneObstacle = Instantiate(Obstacle2, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle3 = Instantiate(Obstacle, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            skill4 = true;
            shakeFlag = true;
        }

        if (myTime > 3.0f && !skill5)
        {
            GameObject Obstacle = (GameObject)Resources.Load("Block_top2");
            GameObject Obstacle2 = (GameObject)Resources.Load("Block_center2");
            GameObject Obstacle3 = (GameObject)Resources.Load("Block3");

            GameObject cloneObstacle = Instantiate(Obstacle2, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle2 = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle3 = Instantiate(Obstacle, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            skill5 = true;
            shakeFlag = true;
        }

        if (myTime > 5.0f && !skill6)
        {
            moveFlag = true;
            skill6 = true;
        }

        if (myTime > 6.0f && !skill7)
        {
            GameObject Enemy2 = (GameObject)Resources.Load("B_DivisionEnemy");
            GameObject Enemy = (GameObject)Resources.Load("Enemy_B1");

            GameObject cloneEnemy = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy2 = Instantiate(Enemy2, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy3 = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            GameObject Obstacle3 = (GameObject)Resources.Load("Block");

            GameObject cloneObstacle2 = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            skill7 = true;
            shakeFlag = true;
        }

        if (myTime > 8.0f && !skill8)
        {
            moveFlag = true;
            skill8 = true;
        }

        if (myTime > 10.0f && !skill1)
        {
            refObj.GetComponent<PlayerScript>().BesideMoveAmount = 15.0f;

            skill1 = true;
            shakeFlag = true;
        }

        if (myTime > 11.0f && !skill9)
        {
            GameObject Enemy2 = (GameObject)Resources.Load("B_DivisionEnemy");
            GameObject Enemy = (GameObject)Resources.Load("Enemy_B1");

            GameObject cloneEnemy = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy2 = Instantiate(Enemy2, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);

            GameObject Obstacle3 = (GameObject)Resources.Load("Block2");
            GameObject Obstacle = (GameObject)Resources.Load("Block_top2");

            GameObject cloneObstacle2 = Instantiate(Obstacle, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle3 = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);

            skill9 = true;
            shakeFlag = true;
        }

        if (myTime > 13.5f && !skill11)
        {
            moveFlag = true;
            skill11 = true;
        }

        if (myTime > 15.0f && !skill2)
        {
            refObj.GetComponent<PlayerScript>().BesideMoveAmount = 5.0f;

            skill2 = true;
            shakeFlag = true;
        }

        if (myTime > 15.5f && !skill10)
        {
            GameObject Enemy2 = (GameObject)Resources.Load("B_DivisionEnemy");
            GameObject Enemy = (GameObject)Resources.Load("Enemy_B1");

            GameObject cloneEnemy = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy2 = Instantiate(Enemy2, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            GameObject Obstacle3 = (GameObject)Resources.Load("Block4");
            GameObject Obstacle2 = (GameObject)Resources.Load("Block");
            GameObject Obstacle = (GameObject)Resources.Load("Block_center2");

            GameObject cloneObstacle2 = Instantiate(Obstacle, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle3 = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle = Instantiate(Obstacle2, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            skill10 = true;
            shakeFlag = true;
        }

        if (myTime > 20.0f && !skill3)
        {
            refObj.GetComponent<PlayerScript>().BesideMoveAmount = 10.0f;

            skill3 = true;
            shakeFlag = true;
        }

        if (myTime > 21.0f && !skill12)
        {
            moveFlag = true;
            skill12 = true;
        }

        if (myTime > 23.0f && !skill13)
        {
            refObj.GetComponent<PlayerScript>().BesideMoveAmount = 15.0f;

            skill13 = true;
            shakeFlag = true;
        }

        if (myTime > 23.5f && !skill17)
        {
            GameObject Enemy = (GameObject)Resources.Load("Enemy_B1");
            GameObject cloneEnemy = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy2 = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy3 = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            GameObject Obstacle2 = (GameObject)Resources.Load("Block_center2");
            GameObject Obstacle = (GameObject)Resources.Load("Block_top2");

            GameObject cloneObstacle = Instantiate(Obstacle2, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle3 = Instantiate(Obstacle, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            skill17 = true;
            shakeFlag = true;
        }

        if (myTime > 25.0f && !skill18)
        {
            GameObject Obstacle4 = (GameObject)Resources.Load("Block_stop");
            GameObject Obstacle3 = (GameObject)Resources.Load("Block_under2");
            GameObject Obstacle2 = (GameObject)Resources.Load("Block2");
            GameObject Obstacle = (GameObject)Resources.Load("Block");

            GameObject cloneObstacle = Instantiate(Obstacle2, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle2 = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle3 = Instantiate(Obstacle, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle4 = Instantiate(Obstacle4, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);


            skill18 = true;
            shakeFlag = true;
        }

        if (myTime > 26.5f && !skill19)
        {
            moveFlag = true;
            skill19 = true;
        }

        if (myTime > 27.5f && !skill20)
        {
            GameObject Enemy2 = (GameObject)Resources.Load("B_DivisionEnemy");
            GameObject Enemy = (GameObject)Resources.Load("Enemy_B1");

            GameObject cloneEnemy = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy2 = Instantiate(Enemy2, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);

            GameObject Obstacle3 = (GameObject)Resources.Load("Block2");
            GameObject Obstacle = (GameObject)Resources.Load("Block_top2");

            GameObject cloneObstacle2 = Instantiate(Obstacle, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle3 = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);

            skill20 = true;
            shakeFlag = true;
        }

        if (myTime > 29.0f && !skill14)
        {
            refObj.GetComponent<PlayerScript>().BesideMoveAmount = 10.0f;

            skill14 = true;
            shakeFlag = true;
        }

        if (myTime > 30.0f && !skill21)
        {
            moveFlag = true;
            skill21 = true;
        }

        if (myTime > 31.5f && !skill22)
        {
            GameObject Enemy = (GameObject)Resources.Load("Enemy_B1");
            GameObject Enemy2 = (GameObject)Resources.Load("B_DivisionEnemy");

            GameObject cloneEnemy = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy2 = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy3 = Instantiate(Enemy, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneEnemy4 = Instantiate(Enemy2, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            skill22 = true;
            shakeFlag = true;
        }

        if (myTime > 32.0f && !skill15)
        {
            refObj.GetComponent<PlayerScript>().BesideMoveAmount = 5.0f;

            skill15 = true;
            shakeFlag = true;
        }

        if (myTime > 32.5f && !skill16)
        {
            GameObject Obstacle3 = (GameObject)Resources.Load("Block_under2");
            GameObject Obstacle2 = (GameObject)Resources.Load("Block2");

            GameObject cloneObstacle = Instantiate(Obstacle2, new Vector3(refObj.GetComponent<PlayerScript>().Next5dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle2 = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);

            skill16 = true;
            shakeFlag = true;
        }

        if (myTime > 34.0f && !skill23)
        {
            moveFlag = true;
            skill23 = true;
        }

        if (myTime > 35.5f && !skill24)
        {
            GameObject Obstacle3 = (GameObject)Resources.Load("Block_under2");
            GameObject Obstacle2 = (GameObject)Resources.Load("Block2");
            GameObject Obstacle = (GameObject)Resources.Load("Block");

            GameObject cloneObstacle = Instantiate(Obstacle3, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle2 = Instantiate(Obstacle2, new Vector3(refObj.GetComponent<PlayerScript>().Next4dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);
            GameObject cloneObstacle3 = Instantiate(Obstacle, new Vector3(refObj.GetComponent<PlayerScript>().Next3dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

            skill24 = true;
            shakeFlag = true;
        }

        if (myTime > 38.0f)
        {
            refObj.GetComponent<PlayerScript>().BesideMoveAmount = 10.0f;

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

        for (int i = 40; i < 45; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 40) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(200, 0, 230, 255);
            }
        }

        for (int i = 45; i < 50; i++)
        {
            float space = heartSpace * 0.5f * (5 - 1);

            if (cloneHeart[i])
            {
                cloneHeart[i].transform.position = new Vector3(this.transform.position.x + ((i - 45) * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);

                cloneHeart[i].GetComponent<SpriteRenderer>().color = new Color32(255, 0, 150, 255);
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
