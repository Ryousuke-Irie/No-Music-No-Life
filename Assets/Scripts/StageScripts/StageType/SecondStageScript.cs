using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondStageScript : StageScript
{
    public GameObject enemyTypeA;
    public GameObject enemyTypeB;
    public GameObject obstacleTypeA;

    private int Max = 0;

    public override void SetStickData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;

        // Stickコピペゾーン --------------------

        SetStick(num++, 1f * vel);
        SetStick(num++, 6f * vel);
        SetStick(num++, 10.5f * vel);
        SetStick(num++, 12.5f * vel);
        SetStick(num++, 15f * vel);
        SetStick(num++, 16f * vel);
        SetStick(num++, 18f * vel);
        SetStick(num++, 20f * vel);
        SetStick(num++, 21f * vel);
        SetStick(num++, 22f * vel);
        SetStick(num++, 23f * vel);
        SetStick(num++, 24.5f * vel);
        SetStick(num++, 25f * vel);
        SetStick(num++, 25.5f * vel);
        SetStick(num++, 26f * vel);
        SetStick(num++, 26.5f * vel);
        SetStick(num++, 27f * vel);
        SetStick(num++, 27.5f * vel);
        SetStick(num++, 28f * vel);
        SetStick(num++, 28.5f * vel);
        SetStick(num++, 29f * vel);
        SetStick(num++, 29.5f * vel);
        SetStick(num++, 30f * vel);
        SetStick(num++, 30.5f * vel);
        SetStick(num++, 31f * vel);
        SetStick(num++, 31.5f * vel);
        SetStick(num++, 32f * vel);
        SetStick(num++, 32.5f * vel);
        SetStick(num++, 33f * vel);
        SetStick(num++, 33.5f * vel);
        SetStick(num++, 34f * vel);
        SetStick(num++, 34.5f * vel);
        SetStick(num++, 35f * vel);
        SetStick(num++, 35.5f * vel);
        SetStick(num++, 36f * vel);
        SetStick(num++, 36.5f * vel);
        SetStick(num++, 37f * vel);
        SetStick(num++, 37.5f * vel);
        SetStick(num++, 41f * vel);
        SetStick(num++, 44.5f * vel);
        SetStick(num++, 47.5f * vel);
        SetStick(num++, 51f * vel);
        SetStick(num++, 54f * vel);
        SetStick(num++, 55.5f * vel);
        SetStick(num++, 57f * vel);
        SetStick(num++, 58f * vel);
        SetStick(num++, 58.5f * vel);
        SetStick(num++, 59f * vel);
        SetStick(num++, 60f * vel);
        SetStick(num++, 61f * vel);
        SetStick(num++, 62f * vel);
        SetStick(num++, 63f * vel);
        SetStick(num++, 63.5f * vel);
        SetStick(num++, 65f * vel);
        SetStick(num++, 69.5f * vel);
        SetStick(num++, 71.5f * vel);
        SetStick(num++, 72f * vel);
        SetStick(num++, 73f * vel);
        SetStick(num++, 74f * vel);
        SetStick(num++, 75f * vel);
        SetStick(num++, 76.5f * vel);
        SetStick(num++, 77f * vel);
        SetStick(num++, 77.5f * vel);
        SetStick(num++, 78f * vel);
        SetStick(num++, 78.5f * vel);
        SetStick(num++, 79f * vel);
        SetStick(num++, 79.5f * vel);
        SetStick(num++, 80f * vel);
        SetStick(num++, 80.5f * vel);
        SetStick(num++, 81f * vel);
        SetStick(num++, 81.5f * vel);
        SetStick(num++, 82f * vel);
        SetStick(num++, 82.5f * vel);
        SetStick(num++, 83f * vel);
        SetStick(num++, 83.5f * vel);
        SetStick(num++, 84f * vel);
        SetStick(num++, 84.5f * vel);
        SetStick(num++, 85f * vel);
        SetStick(num++, 85.5f * vel);
        SetStick(num++, 86f * vel);
        SetStick(num++, 86.5f * vel);
        SetStick(num++, 87f * vel);
        SetStick(num++, 87.5f * vel);
        SetStick(num++, 88f * vel);
        SetStick(num++, 88.5f * vel);
        SetStick(num++, 89f * vel);
        SetStick(num++, 89.5f * vel);
        SetStick(num++, 90f * vel);
        SetStick(num++, 91f * vel);
        SetStick(num++, 92f * vel);
        SetStick(num++, 93f * vel);
        SetStick(num++, 94f * vel);
        SetStick(num++, 95f * vel);
        SetStick(num++, 96f * vel);
        SetStick(num++, 97f * vel);
        SetStick(num++, 98f * vel);
        SetStick(num++, 99f * vel);
        SetStick(num++, 100f * vel);
        SetStick(num++, 101f * vel);

        // --------------------------------------

        Max = num;
    }

    public override void SetEnemyData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        // Enemyコピペゾーン --------------------

        SetEnemy(num++, 10.5f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 21f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 23f * vel - error, -1 * updown, enemyTypeB);
        SetEnemy(num++, 31f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 31f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 36.5f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 37f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 37.5f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 41f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 41f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 41f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 44.5f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 44.5f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 44.5f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 47.5f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 47.5f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 47.5f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 71.5f * vel - error, -1 * updown, enemyTypeB);
        SetEnemy(num++, 80f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 86.5f * vel - error, 1 * updown, enemyTypeB);
        SetEnemy(num++, 90f * vel - error, 0 * updown, enemyTypeB);
        SetEnemy(num++, 95f * vel - error, -1 * updown, enemyTypeB);

        // --------------------------------------
    }

    public override void SetObstacleData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        // Obstacleコピペゾーン -----------------

        SetObstacle(num++, 15f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 18f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 26f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 26f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 27.5f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 29f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 29.5f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 31f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 32.5f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 33f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 35f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 51f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 58f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 58.5f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 61f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 62f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 63.5f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 65f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 76.5f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 77f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 79f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 79.5f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 80.5f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 81f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 83f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 83.5f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 85.5f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 86f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 88.5f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 94f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 99f * vel - error, -1 * updown, obstacleTypeA);

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
