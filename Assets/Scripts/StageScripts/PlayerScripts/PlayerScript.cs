using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    // �ϐ�
    public int HP = 5;

    public float TempoTimeError = 1.5f;

    [System.NonSerialized] public float dist = 0.0f;
    [System.NonSerialized] public float MoveLimit = 140.0f;
    public float BesideMoveAmount = 10.0f;

    private float UpperLimit = 4.0f;
    private float LowerLimit = -4.0f;
    private float VerticalMoveAmount = 4.0f;

    public float PlayerToSlush = 2.0f;

    private float blinkingTime = 0.0f;

    private GameObject SE;
    private GameObject SE2;

    public GameObject BGM;
    private GameObject cloneBGM;

    // �t���O�p�ϐ�
    private bool rotateFlag = false;
    [System.NonSerialized] public bool blinkingFlag = false;

    [System.NonSerialized] public bool actionFlag = false;
    [System.NonSerialized] public bool moveUpFlag = false;
    [System.NonSerialized] public bool moveDownFlag = false;
    [System.NonSerialized] public bool attackFlag = false;

    [System.NonSerialized] public bool startFlag = false;
    [System.NonSerialized] public bool goalFlag = false;

    [System.NonSerialized] public bool oneTimeFlag = false;
    private bool oneTimeFlag2 = false;

    // Start is called before the first frame update
    void Start()
    {
        SE = (GameObject)Resources.Load("SE01");
        SE2 = (GameObject)Resources.Load("SE02");
    }

    void FixedUpdate()
    {
        // �_�ŏ���
        Blinking();

        // ��]����
        Rotate();
    }

    // Update is called once per frame
    void Update()
    {
        if (startFlag)
        {
            // BGM�𗬂�
            if(!oneTimeFlag2)
            {
                cloneBGM = Instantiate(BGM, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                oneTimeFlag2 = true;
            }

            // ���ړ�����
            BesideMove();
        }

        // �㉺�ړ�����
        MoveAction();

        // �U������
        AttackAction();

        // �ʒu����ɂ�鏈��
        PosJudge();

        // HP��0�ɂȂ������̏���
        Dead();

        // �S�[������
        Goal();
    }

    private void Blinking()
    {
        // �_��
        if (blinkingFlag)
        {
            this.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);

            blinkingTime += 0.1f;

            if (blinkingTime > 1.0f)
            {
                this.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                blinkingTime = 0.0f;
                blinkingFlag = false;
            }
        }
    }

    private void Rotate()
    {
        // ��]
        if (rotateFlag)
        {
            this.transform.Rotate(0.0f, 0.0f, -30.0f);
            if (this.transform.localEulerAngles.z <= 3.0f)
            {
                this.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                rotateFlag = false;
            }
        }
    }

    private void BesideMove()
    {
        // ���̈ړ�
        if (this.transform.position.x < MoveLimit)
        {
            this.transform.position += new Vector3(BesideMoveAmount, 0.0f, 0.0f) * Time.deltaTime;
            cloneBGM.transform.position = this.transform.position;
        }
    }

    private void MoveAction()
    {
        // ��ֈړ�
        if (!actionFlag && moveUpFlag)
        {
            if (this.transform.localPosition.y < UpperLimit)
            {
                rotateFlag = true;

                this.transform.position += new Vector3(0.0f, VerticalMoveAmount, 0.0f);

                GameObject cloneSE = Instantiate(SE, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

                actionFlag = true;
            }

            moveUpFlag = false;
        }

        // ���ֈړ�
        if (!actionFlag && moveDownFlag)
        {
            if (this.transform.localPosition.y > LowerLimit)
            {
                rotateFlag = true;

                this.transform.position -= new Vector3(0.0f, VerticalMoveAmount, 0.0f);

                GameObject cloneSE = Instantiate(SE, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

                actionFlag = true;
            }

            moveDownFlag = false;
        }
    }

    private void AttackAction()
    {
        // �U��
        if (!actionFlag && attackFlag)
        {
            rotateFlag = true;

            // �U���G�t�F�N�g(�I�u�W�F�N�g)����
            GameObject Slush = (GameObject)Resources.Load("Slush");
            GameObject cloneSlush = Instantiate(Slush, this.transform.position + new Vector3(PlayerToSlush, 0.0f, 0.0f), Quaternion.identity);

            GameObject cloneSE = Instantiate(SE, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            attackFlag = false;
            actionFlag = true;
        }
    }

    private void PosJudge()
    {
        // �e���|�ɍ��킹��SE��炷����
        if (this.transform.position.x > dist && !oneTimeFlag)
        {
            oneTimeFlag = true;

            GameObject cloneSE2 = Instantiate(SE2, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        }
    }

    private void Dead()
    {
        // �Q�[���I�[�o�[����
        if(HP <= 0)
        {
            SceneManager.LoadScene("FirstStageScene");
        }
    }

    private void Goal()
    {
        // �S�[������
        if (this.transform.position.x >= MoveLimit)
        {
            goalFlag = true;
        }
    }
}
