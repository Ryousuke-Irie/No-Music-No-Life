using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectDivisionEnemyScript : MonoBehaviour
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
    private PlayerScript playerScript;

    [SerializeField] GameObject Enemy1;
    [SerializeField] GameObject Enemy2;
    [SerializeField] GameObject Enemy3;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        refCamera = GameObject.Find("Main Camera");
        tempHP = HP;
        playerScript = refObj.GetComponent<PlayerScript>();

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

        if (refCamera.transform.position.x + 20.0f < this.transform.position.x)
        {
            Destroy(gameObject);
        }

        if (HP <= 0)
        {
            GameObject cloneEnemy = Instantiate(Enemy1, this.transform.position, Quaternion.identity);
            GameObject cloneEnemy2 = Instantiate(Enemy2, this.transform.position, Quaternion.identity);
            GameObject cloneEnemy3 = Instantiate(Enemy3, this.transform.position, Quaternion.identity);

            if (this.transform.position.y > 0.0f)
            {
                cloneEnemy2.GetComponent<ReflectEnemyScript>().VelY = -4.0f;
                cloneEnemy3.GetComponent<ReflectEnemyScript>().VelY = -8.0f;
            }
            else if(this.transform.position.y < -4.0f)
            {
                cloneEnemy.GetComponent<ReflectEnemyScript>().VelY = 8.0f;
                cloneEnemy2.GetComponent<ReflectEnemyScript>().VelY = 4.0f;
            }
            else
            {
                cloneEnemy.GetComponent<ReflectEnemyScript>().VelY = 4.0f;
                cloneEnemy3.GetComponent<ReflectEnemyScript>().VelY = -4.0f;
            }

            Destroy(gameObject);
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

        // HP(ハート)を設置
        for (int i = 0; i < HP; i++)
        {
            float space = heartSpace * 0.5f * (HP - 1);

            if (cloneHeart[i] == null)
            {
                GameObject Heart = (GameObject)Resources.Load("heart");
                cloneHeart[i] = Instantiate(Heart, new Vector3(this.transform.position.x + (i * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f), Quaternion.identity);
            }

            cloneHeart[i].transform.position = new Vector3(this.transform.position.x + (i * heartSpace) - space, this.transform.position.y + heartToEnemy, 0.0f);
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
