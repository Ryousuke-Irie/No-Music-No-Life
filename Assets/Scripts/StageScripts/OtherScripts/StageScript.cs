using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript : MonoBehaviour
{
    // �ÓI�z��ō쐬
    [System.NonSerialized] public GameObject[] stickArray = new GameObject[20];
    [System.NonSerialized] public GameObject[] enemyArray = new GameObject[20];
    [System.NonSerialized] public GameObject[] obstacleArray = new GameObject[20];
    [System.NonSerialized] public GameObject[] enemyTypeArray = new GameObject[150];
    [System.NonSerialized] public GameObject[] obstacleTypeArray = new GameObject[150];

    [System.NonSerialized] public float[] stickPosDataArray = new float[500];
    [System.NonSerialized] public float[] enemyPosXDataArray = new float[150];
    [System.NonSerialized] public float[] enemyPosYDataArray = new float[150];
    [System.NonSerialized] public float[] obstaclePosXDataArray = new float[150];
    [System.NonSerialized] public float[] obstaclePosYDataArray = new float[150];

    [System.NonSerialized] public bool[] stickDataArray = new bool[500];
    [System.NonSerialized] public bool[] enemyDataArray = new bool[150];
    [System.NonSerialized] public bool[] obstacleDataArray = new bool[150];

    [System.NonSerialized] public float updown = 4.0f;

    private GameObject refObj;
    [System.NonSerialized] public GameObject refObjp;
    private GameObject stickObj;

    private GameObject refObjCenter;
    private GameObject refObjUpper;
    private GameObject refObjLower;

    [System.NonSerialized] public int stickNum = 0;

    private float barPos = -2.0f;

    private PlayerScript playerScript;

    // Start is called before the first frame update
    public void Start()
    {
        GameObject refBarA = GameObject.Find("BarTypeA");

        refBarA.transform.position = new Vector3(refBarA.transform.position.x, barPos, refBarA.transform.position.z);

        refObj = GameObject.Find("Main Camera");
        refObjp = GameObject.Find("Player");

        stickObj = (GameObject)Resources.Load("Stick");

        refObjCenter = GameObject.Find("Center");
        refObjUpper = GameObject.Find("Upper");
        refObjLower = GameObject.Find("Lower");

        playerScript = refObjp.GetComponent<PlayerScript>();

        // �S�f�[�^������
        InitData();

        // �S�f�[�^��o�^
        SetStickData();
        SetEnemyData();
        SetObstacleData();

        playerScript.dist = stickPosDataArray[0];
        playerScript.Next2dist = stickPosDataArray[1];
        playerScript.Next3dist = stickPosDataArray[2];
        playerScript.Next4dist = stickPosDataArray[3];
        playerScript.Next5dist = stickPosDataArray[4];
        playerScript.MoveLimit = SetMoveLimit();

        refObjCenter.transform.localScale = new Vector3(SetMoveLimit(), refObjCenter.transform.localScale.y, refObjCenter.transform.localScale.z);
        refObjCenter.transform.position = new Vector3(SetMoveLimit() * 0.5f, refObjCenter.transform.position.y, refObjCenter.transform.position.z);
        refObjUpper.transform.localScale = new Vector3(SetMoveLimit(), refObjUpper.transform.localScale.y, refObjUpper.transform.localScale.z);
        refObjUpper.transform.position = new Vector3(SetMoveLimit() * 0.5f, refObjUpper.transform.position.y, refObjUpper.transform.position.z);
        refObjLower.transform.localScale = new Vector3(SetMoveLimit(), refObjLower.transform.localScale.y, refObjLower.transform.localScale.z);
        refObjLower.transform.position = new Vector3(SetMoveLimit() * 0.5f, refObjLower.transform.position.y, refObjLower.transform.position.z);
    }

    // Update is called once per frame
    public void Update()
    {
        if (playerScript.loopStageFlag)
        {
            ResetData();
            playerScript.loopStageFlag = false;
        }

        // �J�����̈ʒu���Q�Ƃ��ăI�u�W�F�N�g��ݒu���폜����
        float cameraPosLeft = refObj.transform.position.x - 20;
        float cameraPosRight = refObj.transform.position.x + 20;

        // �c�_
        for (int i = 0; i < 500; i++)
        {
            // ��������
            if(stickDataArray[i])  // �f�[�^�����邩
            {
                if (cameraPosLeft <= stickPosDataArray[i] && stickPosDataArray[i] < cameraPosRight) // �����͈͓��ɂ��邩
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (stickArray[j] == null) // �󂢂Ă���I�u�W�F�N�g�p�ϐ������邩
                        {
                            // ����
                            stickArray[j] = Instantiate(stickObj, new Vector3(stickPosDataArray[i], -2.0f, 0.0f), Quaternion.identity);
                            stickDataArray[i] = false; // �d�����č���Ȃ��悤�ɂ��̃f�[�^��false�ɂ���
                            break;
                        }
                    }                  
                }
            }

            // �폜����
            for (int j = 0; j < 20; j++)
            {
                if (stickArray[j] != null) // ��������Ă���I�u�W�F�N�g��T��
                {
                    if(stickArray[j].transform.position.x < cameraPosLeft) // �폜�͈͓��ɂ��邩
                    {
                        // �폜
                        Destroy(stickArray[j], 0.0f);
                        stickArray[j] = null;
                    }
                }
            }               
        }

        // �c�_�t�ߔ���̃��Z�b�g����
        if (refObjp.transform.position.x > playerScript.dist + playerScript.TempoTimeError)
        {
            if (stickNum < GetLastStick())
            {
                stickNum++;

                playerScript.dist = stickPosDataArray[stickNum];

                if (stickNum < GetLastStick() - 1)
                {
                    playerScript.Nextdist = stickPosDataArray[stickNum + 1];
                }

                if (stickNum < GetLastStick() - 2)
                {
                    playerScript.Next2dist = stickPosDataArray[stickNum + 2];
                }

                if (stickNum < GetLastStick() - 3)
                {
                    playerScript.Next3dist = stickPosDataArray[stickNum + 3];
                }

                if (stickNum < GetLastStick() - 4)
                {
                    playerScript.Next4dist = stickPosDataArray[stickNum + 4];
                }

                if (stickNum < GetLastStick() - 5)
                {
                    playerScript.Next5dist = stickPosDataArray[stickNum + 5];
                }

                playerScript.oneTimeFlag = false;

                playerScript.actionFlag = false;
            }
            else
            {
                if (!playerScript.loopFlag)
                {
                    playerScript.lastStickFlag = true;
                }
            }
        }

        // �G
        for (int i = 0; i < 150; i++)
        {
            // ��������
            if (enemyDataArray[i])  // �f�[�^�����邩
            {
                if (cameraPosLeft <= enemyPosXDataArray[i] && enemyPosXDataArray[i] < cameraPosRight) // �����͈͓��ɂ��邩
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (enemyArray[j] == null) // �󂢂Ă���I�u�W�F�N�g�p�ϐ������邩
                        {
                            // ����
                            enemyArray[j] = Instantiate(enemyTypeArray[i], new Vector3(enemyPosXDataArray[i], enemyPosYDataArray[i] - 2.0f, 0.0f), Quaternion.identity);
                            enemyDataArray[i] = false; // �d�����č���Ȃ��悤�ɂ��̃f�[�^��false�ɂ���
                            break;
                        }
                    }
                }
            }

            // �폜����
            for (int j = 0; j < 20; j++)
            {
                if (enemyArray[j] != null) // ��������Ă���I�u�W�F�N�g��T��
                {
                    if (enemyArray[j].transform.position.x < cameraPosLeft) // �폜�͈͓��ɂ��邩
                    {
                        // �폜
                        Destroy(enemyArray[j], 0.0f);
                        enemyArray[j] = null;
                    }
                }
            }
        }

        // ��Q��
        for (int i = 0; i < 150; i++)
        {
            // ��������
            if (obstacleDataArray[i])  // �f�[�^�����邩
            {
                if (cameraPosLeft <= obstaclePosXDataArray[i] && obstaclePosXDataArray[i] < cameraPosRight) // �����͈͓��ɂ��邩
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (obstacleArray[j] == null) // �󂢂Ă���I�u�W�F�N�g�p�ϐ������邩
                        {
                            // ����
                            obstacleArray[j] = Instantiate(obstacleTypeArray[i], new Vector3(obstaclePosXDataArray[i], obstaclePosYDataArray[i] - 2.0f, 0.0f), Quaternion.identity);
                            obstacleDataArray[i] = false; // �d�����č���Ȃ��悤�ɂ��̃f�[�^��false�ɂ���
                            break;
                        }
                    }
                }
            }

            // �폜����
            for (int j = 0; j < 20; j++)
            {
                if (obstacleArray[j] != null) // ��������Ă���I�u�W�F�N�g��T��
                {
                    if (obstacleArray[j].transform.position.x < cameraPosLeft) // �폜�͈͓��ɂ��邩
                    {
                        // �폜
                        Destroy(obstacleArray[j], 0.0f);
                        obstacleArray[j] = null;
                    }
                }
            }
        }
    }

    private void InitData()
    {
        for (int i = 0; i < 500; i++)
        {
            stickDataArray[i] = false;
        }

        for (int i = 0; i < 150; i++)
        {
            enemyDataArray[i] = false;
            obstacleDataArray[i] = false;
        }
    }

    public void SetStick(int num, float x)
    {
        stickDataArray[num] = true;
        stickPosDataArray[num] = x;
    }

    public void SetEnemy(int num, float x, float y, GameObject enemyType)
    {
        enemyDataArray[num] = true;
        enemyPosXDataArray[num] = x;
        enemyPosYDataArray[num] = y;
        enemyTypeArray[num] = enemyType;
    }

    public void SetObstacle(int num, float x, float y, GameObject obstacleType)
    {
        obstacleDataArray[num] = true;
        obstaclePosXDataArray[num] = x;
        obstaclePosYDataArray[num] = y;
        obstacleTypeArray[num] = obstacleType;
    }

    public void ResetData()
    {
        for (int i = 0; i < 500; i++)
        {
            if (stickPosDataArray[i] >= 0.1f)
            {
                stickDataArray[i] = true;
            }
        }

        for (int i = 0; i < 150; i++)
        {
            if (enemyPosXDataArray[i] >= 0.1f)
            {
                enemyDataArray[i] = true;
            }
        }

        for (int i = 0; i < 150; i++)
        {
            if (obstaclePosXDataArray[i] >= 0.1f)
            {
                obstacleDataArray[i] = true;
            }
        }

        stickNum = 0;
    }

    public virtual void SetStickData() { }
    public virtual void SetEnemyData() { }
    public virtual void SetObstacleData() { }
    public virtual float SetMoveLimit() { return 0; }
    public virtual int GetLastStick() { return 0; }
}
