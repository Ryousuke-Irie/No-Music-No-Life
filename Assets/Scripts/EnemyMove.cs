using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    #region // �C���X�y�N�^�[�Őݒ肷��
    [Header("�ړ����x")] public float speed;
    [Header("�d��")] public float gravity;
    [Header("��ʊO�ł��s������")] public bool nonVisibleAct;
	[Header("�ڐG����")] public EnemyCollisionCheck checkCollision;
	[Header("����")] public bool isMove = false;
	[Header("�v���C���[�ƃG�l�~�[�̋���")] public float PlayerToEnemy;
	#endregion

	#region // �v���C�x�[�g�ϐ�
	private Rigidbody2D rb = null;
    private SpriteRenderer sr = null;
	[Header("�������G��Ȃ��I�I������")] public bool rightTleftF = false;
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
