using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    #region // インスペクターで設定する
    [Header("移動速度")] public float speed;
    [Header("重力")] public float gravity;
    [Header("画面外でも行動する")] public bool nonVisibleAct;
	[Header("接触判定")] public EnemyCollisionCheck checkCollision;
	#endregion

	#region // プライベート変数
	private Rigidbody2D rb = null;
    private SpriteRenderer sr = null;
    private bool rightTleftF = false;
	#endregion

	GameObject refObj;

	private void Start()
	{
		refObj = GameObject.Find("Player");
		rb = GetComponent<Rigidbody2D>();
		sr = GetComponent<SpriteRenderer>();
	}

	private void FixedUpdate()
	{
		if (sr.isVisible || nonVisibleAct)
		{
			if (checkCollision.isOn)
			{
				rightTleftF = !rightTleftF;
			}
			int xVector = -1;
			if (rightTleftF)
			{
				xVector = 1;
				gameObject.GetComponent<SpriteRenderer>().flipX = true;
			}
			else
			{
				gameObject.GetComponent<SpriteRenderer>().flipX = false;
			}
			rb.velocity = new Vector2(xVector * speed, -gravity);
		}
		else
		{
			rb.Sleep();
		}
	}

	void Update()
    {
		if (this.transform.position.y < -10.0f)
        {
			Destroy(gameObject);
        }
    }

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			if (!refObj.GetComponent<PlayerStatus>().isDamaged)
			{
				if (refObj.transform.position.x > this.transform.position.x)
				{
					rightTleftF = false;
				}
				else
				{
					rightTleftF = true;
				}
			}
		}
	}
}
