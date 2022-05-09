using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript : MonoBehaviour
{
    // 静的配列で作成
    [System.NonSerialized] public GameObject[] stickArray = new GameObject[20];
    [System.NonSerialized] public GameObject[] enemyArray = new GameObject[20];
    [System.NonSerialized] public GameObject[] obstacleArray = new GameObject[20];
    [System.NonSerialized] public GameObject[] enemyTypeArray = new GameObject[100];
    [System.NonSerialized] public GameObject[] obstacleTypeArray = new GameObject[100];

    [System.NonSerialized] public float[] stickPosDataArray = new float[500];
    [System.NonSerialized] public float[] enemyPosXDataArray = new float[100];
    [System.NonSerialized] public float[] enemyPosYDataArray = new float[100];
    [System.NonSerialized] public float[] obstaclePosXDataArray = new float[100];
    [System.NonSerialized] public float[] obstaclePosYDataArray = new float[100];

    [System.NonSerialized] public bool[] stickDataArray = new bool[500];
    [System.NonSerialized] public bool[] enemyDataArray = new bool[100];
    [System.NonSerialized] public bool[] obstacleDataArray = new bool[100];

    [System.NonSerialized] public float updown = 4.0f;

    private GameObject refObj;
    [System.NonSerialized] public GameObject refObjp;
    private GameObject stickObj;

    private GameObject refObjCenter;
    private GameObject refObjUpper;
    private GameObject refObjLower;

    [System.NonSerialized] public int stickNum = 0;

    // Start is called before the first frame update
    public void Start()
    {
        refObj = GameObject.Find("Main Camera");
        refObjp = GameObject.Find("Player");

        stickObj = (GameObject)Resources.Load("Stick");

        refObjCenter = GameObject.Find("Center");
        refObjUpper = GameObject.Find("Upper");
        refObjLower = GameObject.Find("Lower");

        // 全データ初期化
        InitData();

        // 全データを登録
        SetStickData();
        SetEnemyData();
        SetObstacleData();

        refObjp.GetComponent<PlayerScript>().dist = stickPosDataArray[0];
        refObjp.GetComponent<PlayerScript>().MoveLimit = SetMoveLimit();

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
        // カメラの位置を参照してオブジェクトを設置＆削除する
        float cameraPosLeft = refObj.transform.position.x - 20;
        float cameraPosRight = refObj.transform.position.x + 20;

        // 縦棒
        for (int i = 0; i < 500; i++)
        {
            // 生成処理
            if(stickDataArray[i])  // データがあるか
            {
                if (cameraPosLeft <= stickPosDataArray[i] && stickPosDataArray[i] < cameraPosRight) // 生成範囲内にあるか
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (stickArray[j] == null) // 空いているオブジェクト用変数があるか
                        {
                            // 生成
                            stickArray[j] = Instantiate(stickObj, new Vector3(stickPosDataArray[i], 0.0f, 0.0f), Quaternion.identity);
                            stickDataArray[i] = false; // 重複して作られないようにこのデータはfalseにする
                            break;
                        }
                    }                  
                }
            }

            // 削除処理
            for (int j = 0; j < 20; j++)
            {
                if (stickArray[j] != null) // 生成されているオブジェクトを探す
                {
                    if(stickArray[j].transform.position.x < cameraPosLeft) // 削除範囲内にあるか
                    {
                        // 削除
                        Destroy(stickArray[j], 0.0f);
                        stickArray[j] = null;
                    }
                }
            }               
        }

        // 縦棒付近判定のリセット処理
        if (refObjp.transform.position.x > refObjp.GetComponent<PlayerScript>().dist + refObjp.GetComponent<PlayerScript>().TempoTimeError)
        {
            if(stickNum < GetLastStick())
            {
                stickNum++;

                refObjp.GetComponent<PlayerScript>().dist = stickPosDataArray[stickNum];

                if(stickNum < GetLastStick() - 1)
                {
                    refObjp.GetComponent<PlayerScript>().Nextdist = stickPosDataArray[stickNum + 2];
                }

                if(stickNum < GetLastStick() - 2)
                {
                    refObjp.GetComponent<PlayerScript>().Next2dist = stickPosDataArray[stickNum + 3];
                }

                refObjp.GetComponent<PlayerScript>().oneTimeFlag = false;

                refObjp.GetComponent<PlayerScript>().actionFlag = false;
            }
        }

        // 敵
        for (int i = 0; i < 100; i++)
        {
            // 生成処理
            if (enemyDataArray[i])  // データがあるか
            {
                if (cameraPosLeft <= enemyPosXDataArray[i] && enemyPosXDataArray[i] < cameraPosRight) // 生成範囲内にあるか
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (enemyArray[j] == null) // 空いているオブジェクト用変数があるか
                        {
                            // 生成
                            enemyArray[j] = Instantiate(enemyTypeArray[j], new Vector3(enemyPosXDataArray[i], enemyPosYDataArray[i], 0.0f), Quaternion.identity);
                            enemyDataArray[i] = false; // 重複して作られないようにこのデータはfalseにする
                            break;
                        }
                    }
                }
            }

            // 削除処理
            for (int j = 0; j < 20; j++)
            {
                if (enemyArray[j] != null) // 生成されているオブジェクトを探す
                {
                    if (enemyArray[j].transform.position.x < cameraPosLeft) // 削除範囲内にあるか
                    {
                        // 削除
                        Destroy(enemyArray[j], 0.0f);
                        enemyArray[j] = null;
                    }
                }
            }
        }

        // 障害物
        for (int i = 0; i < 100; i++)
        {
            // 生成処理
            if (obstacleDataArray[i])  // データがあるか
            {
                if (cameraPosLeft <= obstaclePosXDataArray[i] && obstaclePosXDataArray[i] < cameraPosRight) // 生成範囲内にあるか
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (obstacleArray[j] == null) // 空いているオブジェクト用変数があるか
                        {
                            // 生成
                            obstacleArray[j] = Instantiate(obstacleTypeArray[i], new Vector3(obstaclePosXDataArray[i], obstaclePosYDataArray[i], 0.0f), Quaternion.identity);
                            obstacleDataArray[i] = false; // 重複して作られないようにこのデータはfalseにする
                            break;
                        }
                    }
                }
            }

            // 削除処理
            for (int j = 0; j < 20; j++)
            {
                if (obstacleArray[j] != null) // 生成されているオブジェクトを探す
                {
                    if (obstacleArray[j].transform.position.x < cameraPosLeft) // 削除範囲内にあるか
                    {
                        // 削除
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

        for (int i = 0; i < 100; i++)
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

    public virtual void SetStickData() { }
    public virtual void SetEnemyData() { }
    public virtual void SetObstacleData() { }
    public virtual float SetMoveLimit() { return 0; }
    public virtual int GetLastStick() { return 0; }
}
