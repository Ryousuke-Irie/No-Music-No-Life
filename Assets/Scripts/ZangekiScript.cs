using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZangekiScript : MonoBehaviour
{
    GameObject refObj;
    PlayerStatus playerStatus;

    public float Power = 1.0f;
    public float minusScale = 0.0005f;
    public float deleteScale = 0.05f;
    public float initialScaleMag = 0.25f;
    public float PowerMag = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        playerStatus = refObj.GetComponent<PlayerStatus>();

        Power = playerStatus.Power * this.transform.localScale.x * PowerMag;

        this.transform.localScale = new Vector3(playerStatus.TempoTime * initialScaleMag, playerStatus.TempoTime * initialScaleMag, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale += new Vector3(-minusScale, -minusScale, 0.0f);
        Power = playerStatus.Power * this.transform.localScale.x * PowerMag;

        if (this.transform.localScale.x < deleteScale)
        {
            Destroy(gameObject, 0.0f);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Wall")
        {
            Destroy(gameObject, 0.0f);
        }
    }
}
