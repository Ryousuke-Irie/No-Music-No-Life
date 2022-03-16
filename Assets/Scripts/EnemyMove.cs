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

	private void Start()
	{
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
				transform.localScale = new Vector3(-1, 1, 1);
			}
			else
			{
				transform.localScale = new Vector3(1, 1, 1);
			}
			rb.velocity = new Vector2(xVector * speed, -gravity);
		}
		else
		{
			rb.Sleep();
		}
	}
}
