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
	[Header("動く")] public bool isMove = false;
	[Header("プレイヤーとエネミーの距離")] public float PlayerToEnemy;
	#endregion

	#region // プライベート変数
	private Rigidbody2D rb = null;
    private SpriteRenderer sr = null;
	[Header("↓↓↓触らない！！↓↓↓")] public bool rightTleftF = false;
	private float speedOriginel;
	#endregion

	GameObject refObj;

	private void Start()
	{
		refObj = GameObject.Find("Player");
		rb = GetComponent<Rigidbody2D>();
		sr = GetComponent<SpriteRenderer>();
		speedOriginel = speed;
	}

	private void FixedUpdate()
	{
		float dist = this.transform.position.x - refObj.transform.position.x;

		if (!this.GetComponent<EnemyScript>().floorFlag)
        {
			speed = 0.0f;
        }

		if (this.GetComponent<EnemyScript>().floorFlag)
		{
			speed = speedOriginel;
		}

		if (dist < 0.0f)
		{
			dist *= -1;
		}

		if ((sr.isVisible || nonVisibleAct) && isMove && PlayerToEnemy > dist)
		{
			if (checkCollision.isOn)
			{
				rightTleftF = !rightTleftF;
				transform.localScale = new Vector3(-1 * transform.localScale.x, 1 * transform.localScale.y, 1);
			}
			int xVector = -1;
			if (rightTleftF)
			{
				xVector = 1;
			}
			else
			{

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
}
