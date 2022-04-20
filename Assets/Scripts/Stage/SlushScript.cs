using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlushScript : MonoBehaviour
{
    private ParticleSystem ps;
    private bool colFlag = false;
    private bool oneTimeFlag = false;
    private float time = 0.0f;

    private bool isRight = false;

    public float ZangekiTime = 0.2f;

    private float ZangekiSpeed = 15.0f;

    GameObject refObj;
    PlayerStatus playerStatus;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();

        refObj = GameObject.Find("Player");
        playerStatus = refObj.GetComponent<PlayerStatus>();

        isRight = playerStatus.isRight;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            colFlag = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = refObj.transform.position + new Vector3(3.0f, 0.0f, 0.0f);

        if (!oneTimeFlag)
        {
            if (time > 0.05f)
            {
                time = 0.05f;
            }
            else
            {
                time += Time.deltaTime;
            }
        }

        if (!colFlag && !oneTimeFlag && time >= 0.05f && playerStatus.intervalFlag && playerStatus.TempoTime > ZangekiTime)
        {
            GameObject Slush = (GameObject)Resources.Load("Zangeki");
            GameObject cloneSlush = Instantiate(Slush, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            cloneSlush.GetComponent<SpriteRenderer>().color = new Color32(255, (byte)playerStatus.Green, (byte)playerStatus.Blue, 255);

            if (isRight)
            {
                cloneSlush.GetComponent<Rigidbody2D>().velocity = new Vector2(ZangekiSpeed, 0.0f);
                cloneSlush.GetComponent<ZangekiScript>().rotateFlag = true;
            }

            if (!isRight)
            {
                cloneSlush.GetComponent<Rigidbody2D>().velocity = new Vector2(-ZangekiSpeed, 0.0f);
                cloneSlush.GetComponent<SpriteRenderer>().flipX = false;
                cloneSlush.GetComponent<ZangekiScript>().rotateFlag = true;
            }

            oneTimeFlag = true;
        }

        if (!ps.isPlaying)
        {
            Destroy(gameObject, 0.0f);
        }
    }
}
