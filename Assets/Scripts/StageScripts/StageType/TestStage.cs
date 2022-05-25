using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStage : StageScript
{
    public GameObject enemyTypeA;
    public GameObject enemyTypeB;
    public GameObject enemyTypeC;
    public GameObject enemyTypeD;
    public GameObject obstacleTypeA;
    public GameObject obstacleTypeB;
    public GameObject obstacleTypeC;
    public GameObject obstacleTypeD;
    public GameObject obstacleTypeE;
    public GameObject obstacleTypeF;
    public GameObject obstacleTypeG;
    public GameObject obstacleTypeH;
    public GameObject obstacleTypeI;
    public GameObject obstacleTypeJ;

    private int Max = 0;

    public override void SetStickData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;

        // Stickコピペゾーン --------------------

        //SetStick(num++, 0.5f * vel);
        //SetStick(num++, 1f * vel);
        //SetStick(num++, 1.5f * vel);
        //SetStick(num++, 2f * vel);
        //SetStick(num++, 2.5f * vel);
        //SetStick(num++, 3f * vel);
        //SetStick(num++, 3.5f * vel);
        //SetStick(num++, 4f * vel);
        //SetStick(num++, 4.5f * vel);
        //SetStick(num++, 5f * vel);
        //SetStick(num++, 5.5f * vel);
        //SetStick(num++, 6f * vel);
        //SetStick(num++, 6.5f * vel);
        //SetStick(num++, 7f * vel);
        //SetStick(num++, 7.5f * vel);
        //SetStick(num++, 8f * vel);
        //SetStick(num++, 8.5f * vel);
        //SetStick(num++, 9f * vel);
        //SetStick(num++, 9.5f * vel);
        //SetStick(num++, 10f * vel);
        //SetStick(num++, 10.5f * vel);
        //SetStick(num++, 11f * vel);
        //SetStick(num++, 11.5f * vel);
        //SetStick(num++, 12f * vel);
        //SetStick(num++, 12.5f * vel);
        //SetStick(num++, 13f * vel);
        //SetStick(num++, 13.5f * vel);
        //SetStick(num++, 14f * vel);
        //SetStick(num++, 14.5f * vel);
        //SetStick(num++, 15f * vel);
        //SetStick(num++, 15.5f * vel);
        //SetStick(num++, 16f * vel);
        //SetStick(num++, 16.5f * vel);
        //SetStick(num++, 17f * vel);
        //SetStick(num++, 17.5f * vel);
        //SetStick(num++, 18f * vel);
        //SetStick(num++, 18.5f * vel);
        //SetStick(num++, 19f * vel);
        //SetStick(num++, 19.5f * vel);
        //SetStick(num++, 20f * vel);
        //SetStick(num++, 20.5f * vel);
        //SetStick(num++, 21f * vel);
        //SetStick(num++, 21.5f * vel);
        //SetStick(num++, 22f * vel);
        //SetStick(num++, 22.5f * vel);
        //SetStick(num++, 23f * vel);
        //SetStick(num++, 23.5f * vel);
        //SetStick(num++, 24f * vel);
        //SetStick(num++, 24.5f * vel);
        //SetStick(num++, 25f * vel);
        //SetStick(num++, 25.5f * vel);
        //SetStick(num++, 26f * vel);
        //SetStick(num++, 26.5f * vel);
        //SetStick(num++, 27f * vel);
        //SetStick(num++, 27.5f * vel);
        //SetStick(num++, 28f * vel);
        //SetStick(num++, 28.3f * vel);
        //SetStick(num++, 28.7f * vel);
        //SetStick(num++, 29f * vel);
        //SetStick(num++, 29.5f * vel);
        //SetStick(num++, 30f * vel);
        //SetStick(num++, 30.5f * vel);
        //SetStick(num++, 31f * vel);
        //SetStick(num++, 31.5f * vel);
        //SetStick(num++, 32f * vel);
        //SetStick(num++, 32.5f * vel);
        //SetStick(num++, 33f * vel);
        //SetStick(num++, 33.5f * vel);
        //SetStick(num++, 34f * vel);
        //SetStick(num++, 34.5f * vel);
        //SetStick(num++, 35f * vel);
        //SetStick(num++, 35.5f * vel);
        //SetStick(num++, 36f * vel);
        //SetStick(num++, 36.5f * vel);
        //SetStick(num++, 37f * vel);
        //SetStick(num++, 37.5f * vel);
        //SetStick(num++, 38f * vel);
        //SetStick(num++, 38.5f * vel);
        //SetStick(num++, 39f * vel);
        //SetStick(num++, 39.5f * vel);
        //SetStick(num++, 40f * vel);
        //SetStick(num++, 40.5f * vel);
        //SetStick(num++, 41f * vel);
        //SetStick(num++, 41.5f * vel);
        //SetStick(num++, 42f * vel);
        //SetStick(num++, 42.5f * vel);
        //SetStick(num++, 43f * vel);
        //SetStick(num++, 43.5f * vel);
        //SetStick(num++, 44f * vel);
        //SetStick(num++, 44.5f * vel);
        //SetStick(num++, 45f * vel);
        //SetStick(num++, 45.5f * vel);
        //SetStick(num++, 46f * vel);
        //SetStick(num++, 46.4f * vel);
        //SetStick(num++, 46.7f * vel);
        //SetStick(num++, 47f * vel);
        //SetStick(num++, 47.3f * vel);
        //SetStick(num++, 47.7f * vel);
        //SetStick(num++, 48f * vel);
        //SetStick(num++, 48.5f * vel);
        //SetStick(num++, 49f * vel);
        //SetStick(num++, 49.5f * vel);
        //SetStick(num++, 50f * vel);
        //SetStick(num++, 50.5f * vel);
        //SetStick(num++, 51f * vel);
        //SetStick(num++, 51.5f * vel);
        //SetStick(num++, 52f * vel);
        //SetStick(num++, 52.5f * vel);
        //SetStick(num++, 53f * vel);
        //SetStick(num++, 53.5f * vel);
        //SetStick(num++, 54f * vel);
        //SetStick(num++, 54.5f * vel);
        //SetStick(num++, 55f * vel);
        //SetStick(num++, 55.5f * vel);
        //SetStick(num++, 56f * vel);
        //SetStick(num++, 56.5f * vel);
        //SetStick(num++, 57f * vel);
        //SetStick(num++, 57.5f * vel);
        //SetStick(num++, 58f * vel);
        //SetStick(num++, 58.5f * vel);
        //SetStick(num++, 59f * vel);
        //SetStick(num++, 59.5f * vel);
        //SetStick(num++, 60f * vel);
        //SetStick(num++, 60.5f * vel);
        //SetStick(num++, 61f * vel);
        //SetStick(num++, 61.5f * vel);
        //SetStick(num++, 62f * vel);
        //SetStick(num++, 62.5f * vel);
        //SetStick(num++, 63f * vel);
        //SetStick(num++, 63.5f * vel);
        //SetStick(num++, 64f * vel);
        //SetStick(num++, 64.5f * vel);
        //SetStick(num++, 65f * vel);
        //SetStick(num++, 65.5f * vel);
        //SetStick(num++, 66f * vel);
        //SetStick(num++, 66.5f * vel);
        //SetStick(num++, 67f * vel);
        //SetStick(num++, 67.5f * vel);
        //SetStick(num++, 68f * vel);
        //SetStick(num++, 68.5f * vel);
        //SetStick(num++, 69f * vel);
        //SetStick(num++, 69.5f * vel);
        //SetStick(num++, 70f * vel);
        //SetStick(num++, 70.5f * vel);
        //SetStick(num++, 71f * vel);
        //SetStick(num++, 71.5f * vel);
        //SetStick(num++, 72f * vel);
        //SetStick(num++, 72.5f * vel);
        //SetStick(num++, 73f * vel);
        //SetStick(num++, 73.5f * vel);
        //SetStick(num++, 74f * vel);
        //SetStick(num++, 74.5f * vel);
        //SetStick(num++, 75f * vel);
        //SetStick(num++, 75.5f * vel);
        //SetStick(num++, 76f * vel);
        //SetStick(num++, 76.5f * vel);
        //SetStick(num++, 77f * vel);
        //SetStick(num++, 77.5f * vel);
        //SetStick(num++, 78f * vel);
        //SetStick(num++, 78.5f * vel);
        //SetStick(num++, 79f * vel);
        //SetStick(num++, 79.5f * vel);
        //SetStick(num++, 80f * vel);
        //SetStick(num++, 80.5f * vel);
        //SetStick(num++, 81f * vel);
        //SetStick(num++, 81.5f * vel);
        //SetStick(num++, 82f * vel);
        //SetStick(num++, 82.5f * vel);
        //SetStick(num++, 83f * vel);
        //SetStick(num++, 83.5f * vel);
        //SetStick(num++, 84f * vel);
        //SetStick(num++, 84.5f * vel);
        //SetStick(num++, 85f * vel);

        SetStick(num++, 1f * vel);
        SetStick(num++, 3.1f * vel);
        SetStick(num++, 3.8f * vel);
        SetStick(num++, 4.6f * vel);
        SetStick(num++, 6.5f * vel);
        SetStick(num++, 7.5f * vel);
        SetStick(num++, 8f * vel);
        SetStick(num++, 10f * vel);
        SetStick(num++, 11f * vel);
        SetStick(num++, 12.7f * vel);
        SetStick(num++, 13.7f * vel);
        SetStick(num++, 14.5f * vel);
        SetStick(num++, 21.5f * vel);
        SetStick(num++, 22f * vel);
        SetStick(num++, 25f * vel);
        SetStick(num++, 25.5f * vel);
        SetStick(num++, 29f * vel);
        SetStick(num++, 30.5f * vel);
        SetStick(num++, 32f * vel);
        SetStick(num++, 33.5f * vel);
        SetStick(num++, 35f * vel);
        SetStick(num++, 36.5f * vel);
        SetStick(num++, 38f * vel);
        SetStick(num++, 39.5f * vel);
        SetStick(num++, 41f * vel);

        SetStick(num++, 42f * vel);
        SetStick(num++, 42.45f * vel);
        SetStick(num++, 42.9f * vel);//43
        SetStick(num++, 43.35f * vel);
        SetStick(num++, 43.8f * vel);//44
        SetStick(num++, 44.25f * vel);
        SetStick(num++, 44.7f * vel);//45
        SetStick(num++, 45.15f * vel);
        SetStick(num++, 45.6f * vel);//46
        SetStick(num++, 46.05f * vel);
        SetStick(num++, 46.5f * vel);//47
        SetStick(num++, 46.95f * vel);
        SetStick(num++, 47.4f * vel);//48
        SetStick(num++, 47.85f * vel);
        SetStick(num++, 48.3f * vel);//49
        SetStick(num++, 48.75f * vel);
        SetStick(num++, 49.2f * vel);//50
        SetStick(num++, 49.65f * vel);
        SetStick(num++, 50.1f * vel);//51
        SetStick(num++, 50.55f * vel);
        SetStick(num++, 51f * vel);//52
        SetStick(num++, 51.45f * vel);
        SetStick(num++, 51.9f * vel);//53
        SetStick(num++, 52.35f * vel);
        SetStick(num++, 52.8f * vel);//54
        SetStick(num++, 53.25f * vel);
        SetStick(num++, 53.7f * vel);//55
        SetStick(num++, 54.15f * vel);
        SetStick(num++, 54.6f * vel);
        SetStick(num++, 55.05f * vel);
        SetStick(num++, 55.5f * vel);
        SetStick(num++, 55.95f * vel);
        SetStick(num++, 56.4f * vel);
        SetStick(num++, 56.85f * vel);
        SetStick(num++, 57.3f * vel);
        SetStick(num++, 57.75f * vel);

        SetStick(num++, 59f * vel);
        SetStick(num++, 61f * vel);
        SetStick(num++, 62f * vel);
        SetStick(num++, 62.5f * vel);
        SetStick(num++, 64.5f * vel);
        SetStick(num++, 65.2f * vel);
        SetStick(num++, 68f * vel);
        SetStick(num++, 69f * vel);
        SetStick(num++, 70.5f * vel);
        SetStick(num++, 71.5f * vel);
        SetStick(num++, 72.4f * vel);
        SetStick(num++, 73f * vel);
        SetStick(num++, 75f * vel);
        SetStick(num++, 76f * vel);
        SetStick(num++, 77f * vel);
        SetStick(num++, 78f * vel);
        SetStick(num++, 79.4f * vel);
        SetStick(num++, 80f * vel);
        SetStick(num++, 82f * vel);
        SetStick(num++, 83f * vel);
        SetStick(num++, 85f * vel);
        SetStick(num++, 86f * vel);
        SetStick(num++, 86.8f * vel);
        SetStick(num++, 87.5f * vel);
        SetStick(num++, 89.3f * vel);
        SetStick(num++, 90.5f * vel);
        SetStick(num++, 91.5f * vel);
        SetStick(num++, 91.9f * vel);
        SetStick(num++, 93f * vel);
        SetStick(num++, 94f * vel);
        SetStick(num++, 96.5f * vel);
        SetStick(num++, 97.5f * vel);
        SetStick(num++, 99f * vel);

        SetStick(num++, 100f * vel);
        SetStick(num++, 100.45f * vel);
        SetStick(num++, 100.9f * vel);//1
        SetStick(num++, 101.35f * vel);
        SetStick(num++, 101.8f * vel);//2
        SetStick(num++, 102.25f * vel);
        SetStick(num++, 102.7f * vel);//3
        SetStick(num++, 103.15f * vel);
        SetStick(num++, 103.6f * vel);//4
        SetStick(num++, 104.05f * vel);
        SetStick(num++, 104.5f * vel);//5
        SetStick(num++, 104.95f * vel);
        SetStick(num++, 105.4f * vel);//6
        SetStick(num++, 105.85f * vel);
        SetStick(num++, 106.3f * vel);//7
        SetStick(num++, 106.75f * vel);
        SetStick(num++, 107.2f * vel);//8
        SetStick(num++, 107.65f * vel);
        SetStick(num++, 108.1f * vel);//9
        SetStick(num++, 108.55f * vel);
        SetStick(num++, 109f * vel);//10
        SetStick(num++, 109.45f * vel);
        SetStick(num++, 109.9f * vel);//11
        SetStick(num++, 110.35f * vel);
        SetStick(num++, 110.8f * vel);//12
        SetStick(num++, 111.25f * vel);
        SetStick(num++, 111.7f * vel);//13
        SetStick(num++, 112.15f * vel);
        SetStick(num++, 112.6f * vel);//14
        SetStick(num++, 113.05f * vel);
        SetStick(num++, 113.5f * vel);//15
        SetStick(num++, 113.95f * vel);
        SetStick(num++, 114.4f * vel);//16
        SetStick(num++, 114.85f * vel);
        SetStick(num++, 115.3f * vel);
        SetStick(num++, 115.75f * vel);

        SetStick(num++, 117f * vel);
        SetStick(num++, 118f * vel);
        SetStick(num++, 119f * vel);
        SetStick(num++, 120f * vel);

        // --------------------------------------

        Max = num;
    }

    public override void SetEnemyData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        // Enemyコピペゾーン --------------------

        //SetEnemy(num++, 5.5f * vel - error, 1 * updown, enemyTypeB);
        //SetEnemy(num++, 7f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 11f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 12.5f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 18.5f * vel - error, 1 * updown, enemyTypeB);
        //SetEnemy(num++, 20f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 21f * vel - error, 0 * updown, enemyTypeB);
        //SetEnemy(num++, 23f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 24f * vel - error, 1 * updown, enemyTypeB);
        //SetEnemy(num++, 25.5f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 26.5f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 29f * vel - error, 0 * updown, enemyTypeB);
        //SetEnemy(num++, 30f * vel - error, 0 * updown, enemyTypeB);
        //SetEnemy(num++, 31f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 32f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 33.5f * vel - error, -1 * updown, enemyTypeB);
        //SetEnemy(num++, 33.5f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 33.5f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 36f * vel - error, 1 * updown, enemyTypeB);
        //SetEnemy(num++, 37f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 38f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 38f * vel - error, 0 * updown, enemyTypeB);
        //SetEnemy(num++, 38f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 42f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 44f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 45.5f * vel - error, 0 * updown, enemyTypeB);
        //SetEnemy(num++, 49f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 51f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 52.5f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 55f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 56f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 60f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 61f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 63f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 63f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 63f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 65f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 66f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 71f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 72.5f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 75f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 75f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 75f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 80.5f * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, 80.5f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 80.5f * vel - error, 1 * updown, enemyTypeA);
        //SetEnemy(num++, 85f * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, 3.8f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 13.7f * vel - error, 1 * updown, enemyTypeB);

        SetEnemy(num++, 14.5f * vel - error, 0 * updown, enemyTypeD);
        SetEnemy(num++, 19.5f * vel - error, -1 * updown, enemyTypeD);
        SetEnemy(num++, 24.5f * vel - error, 1 * updown, enemyTypeD);

        SetEnemy(num++, 35f * vel - error, -1 * updown, enemyTypeC);
        SetEnemy(num++, 41f * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, 45.6f * vel - error, -1 * updown, enemyTypeC);
        SetEnemy(num++, 47.4f * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, 49.5f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 49.65f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 50.55f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 53.7f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 54.6f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 55.5f * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, 62.5f * vel - error, 0 * updown, enemyTypeD);

        SetEnemy(num++, 65.2f * vel - error, -1 * updown, enemyTypeC);
        SetEnemy(num++, 70.5f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 73f * vel - error, 1 * updown, enemyTypeB);

        SetEnemy(num++, 79.5f * vel - error, -1 * updown, enemyTypeD);
        SetEnemy(num++, 82.0f * vel - error, 1 * updown, enemyTypeD);
        SetEnemy(num++, 85.0f * vel - error, -1 * updown, enemyTypeD);

        SetEnemy(num++, 86.8f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 89.3f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 91.5f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 93f * vel - error, 1 * updown, enemyTypeA);

        SetEnemy(num++, 93.0f * vel - error, -1 * updown, enemyTypeD);
        SetEnemy(num++, 94.0f * vel - error, 0 * updown, enemyTypeD);
        SetEnemy(num++, 97.5f * vel - error, 1 * updown, enemyTypeD);

        SetEnemy(num++, 100f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 100.9f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 102.25f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 103.15f * vel - error, 1 * updown, enemyTypeB);
        SetEnemy(num++, 105.4f * vel - error, 1 * updown, enemyTypeB);
        SetEnemy(num++, 109f * vel - error, 0 * updown, enemyTypeB);
        SetEnemy(num++, 111.25f * vel - error, -1 * updown, enemyTypeC);

        SetEnemy(num++, 117f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 119f * vel - error, 1 * updown, enemyTypeA);

        // --------------------------------------
    }

    public override void SetObstacleData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        // Obstacleコピペゾーン -----------------

        //SetObstacle(num++, 2f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 3f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 4.5f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 8.5f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 10f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 13.5f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 15f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 16f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 16f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 19f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 20.5f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 21.5f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 24f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 26f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 26.5f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 30f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 31.5f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 35f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 35f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 40.5f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 40.5f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 42.5f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 46.4f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 47f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 47.7f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 51.5f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 53f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 56.5f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 57f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 58.5f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 67f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 67.5f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 68.5f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 69f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 71f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 71f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 72f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 72f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 73.5f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 76f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 76f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 77.5f * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, 78f * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, 83f * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, 83f * vel - error, 1 * updown, obstacleTypeA);

        SetObstacle(num++, 3.8f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 6.5f * vel - error, 0 * updown, obstacleTypeB);
        SetObstacle(num++, 10f * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, 11f * vel - error, 0 * updown, obstacleTypeG);
        SetObstacle(num++, 25f * vel - error, 0 * updown, obstacleTypeI);
        //SetObstacle(num++, 25.5f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 32f * vel - error, 1 * updown, obstacleTypeH);
        SetObstacle(num++, 33.5f * vel - error, 0 * updown, obstacleTypeC);
        SetObstacle(num++, 38f * vel - error, 1 * updown, obstacleTypeE);
        SetObstacle(num++, 39.5f * vel - error, -1 * updown, obstacleTypeB);

        SetObstacle(num++, 42.9f * vel - error, 1 * updown, obstacleTypeD);
        SetObstacle(num++, 43.35f * vel - error, 0 * updown, obstacleTypeF);
        SetObstacle(num++, 44.7f * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, 45.15f * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, 46.5f * vel - error, 1 * updown, obstacleTypeG);
        SetObstacle(num++, 46.95f * vel - error, -1 * updown, obstacleTypeB);
        SetObstacle(num++, 56.4f * vel - error, 1 * updown, obstacleTypeC);

        SetObstacle(num++, 59f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 62f * vel - error, 1 * updown, obstacleTypeD);
        SetObstacle(num++, 62.5f * vel - error, 0 * updown, obstacleTypeE);
        SetObstacle(num++, 79.4f * vel - error, 1 * updown, obstacleTypeB);
        SetObstacle(num++, 80f * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, 83f * vel - error, 1 * updown, obstacleTypeH);
        SetObstacle(num++, 85f * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, 87.5f * vel - error, 0 * updown, obstacleTypeC);
        SetObstacle(num++, 90.5f * vel - error, -1 * updown, obstacleTypeF);
        SetObstacle(num++, 91.9f * vel - error, 0 * updown, obstacleTypeB);

        SetObstacle(num++, 100f * vel - error, -1 * updown, obstacleTypeC);
        SetObstacle(num++, 100.9f * vel - error, 1 * updown, obstacleTypeG);
        SetObstacle(num++, 102.25f * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, 103.15f * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, 105.4f * vel - error, 0 * updown, obstacleTypeF);
        SetObstacle(num++, 107.2f * vel - error, 1 * updown, obstacleTypeE);
        SetObstacle(num++, 107.65f * vel - error, -1 * updown, obstacleTypeD);
        SetObstacle(num++, 109f * vel - error, 1 * updown, obstacleTypeH);
        SetObstacle(num++, 111.25f * vel - error, 1 * updown, obstacleTypeG);
        SetObstacle(num++, 112.6f * vel - error, 0 * updown, obstacleTypeB);
        SetObstacle(num++, 113.5f * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, 114.4f * vel - error, 0 * updown, obstacleTypeD);

        SetObstacle(num++, 118f * vel - error, 0 * updown, obstacleTypeI);

        // --------------------------------------
    }

    public override float SetMoveLimit()
    {
        // return ((stickPosDataArray[Max - 1]) + 6.0f);
        return ((stickPosDataArray[Max - 1]) + 36.0f);
    }

    public override int GetLastStick()
    {
        return (Max - 1);
    }
}
