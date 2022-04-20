using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // �ϐ�
    public float TempoTimeError = 1.5f;

    [System.NonSerialized] public float dist = 0.0f;
    private float MoveLimit = 140.0f;
    private float BesideMoveAmount = 10.0f;

    private float UpperLimit = 4.0f;
    private float LowerLimit = -4.0f;
    private float VerticalMoveAmount = 4.0f;

    public float PlayerToSlush = 2.0f;

    private GameObject SE;
    private GameObject SE2;
    private GameObject Slush;

    // �t���O�p�ϐ�
    private bool rotateFlag = false;

    [System.NonSerialized] public bool actionFlag = false;
    [System.NonSerialized] public bool moveUpFlag = false;
    [System.NonSerialized] public bool moveDownFlag = false;
    [System.NonSerialized] public bool attackFlag = false;

    private bool oneTimeFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        SE = (GameObject)Resources.Load("SE01");
        SE2 = (GameObject)Resources.Load("SE02");
        Slush = (GameObject)Resources.Load("Slush");

        dist = 5.5f;
    }

    void FixedUpdate()
    {
        // ��]����
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

    // Update is called once per frame
    void Update()
    {
        // ���ړ�����
        if (this.transform.position.x < MoveLimit)
        {
            this.transform.position += new Vector3(BesideMoveAmount, 0.0f, 0.0f) * Time.deltaTime;
        }

        // �㉺�ړ�����
        MoveAction();

        // �U������
        AttackAction();

        // �ʒu����ɂ�鏈��
        PosJudge();
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

                moveUpFlag = false;
                actionFlag = true;
            }
        }

        // ���ֈړ�
        if (!actionFlag && moveDownFlag)
        {
            if (this.transform.localPosition.y > LowerLimit)
            {
                rotateFlag = true;

                this.transform.position -= new Vector3(0.0f, VerticalMoveAmount, 0.0f);

                GameObject cloneSE = Instantiate(SE, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

                moveDownFlag = false;
                actionFlag = true;
            }
        }
    }

    private void AttackAction()
    {
        // �U��
        if (!actionFlag && attackFlag)
        {
            rotateFlag = true;
                        
            // �U���G�t�F�N�g(�I�u�W�F�N�g)����
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

        // ����̃��Z�b�g����
        if (this.transform.position.x > dist + TempoTimeError)
        {
            dist += 6.0f;

            oneTimeFlag = false;

            actionFlag = false;
        }
    }
}
