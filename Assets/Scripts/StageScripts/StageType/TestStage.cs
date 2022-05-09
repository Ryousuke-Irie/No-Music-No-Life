using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStage : StageScript
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

        SetStick(num++, 0.5f * vel);
        SetStick(num++, 1f * vel);
        SetStick(num++, 1.5f * vel);
        SetStick(num++, 2f * vel);
        SetStick(num++, 2.5f * vel);
        SetStick(num++, 3f * vel);
        SetStick(num++, 3.5f * vel);
        SetStick(num++, 4f * vel);
        SetStick(num++, 4.5f * vel);
        SetStick(num++, 5f * vel);
        SetStick(num++, 5.5f * vel);
        SetStick(num++, 6f * vel);
        SetStick(num++, 6.5f * vel);
        SetStick(num++, 7f * vel);
        SetStick(num++, 7.5f * vel);
        SetStick(num++, 8f * vel);
        SetStick(num++, 8.5f * vel);
        SetStick(num++, 9f * vel);
        SetStick(num++, 9.5f * vel);
        SetStick(num++, 10f * vel);
        SetStick(num++, 10.5f * vel);
        SetStick(num++, 11f * vel);
        SetStick(num++, 11.5f * vel);
        SetStick(num++, 12f * vel);
        SetStick(num++, 12.5f * vel);
        SetStick(num++, 13f * vel);
        SetStick(num++, 13.5f * vel);
        SetStick(num++, 14f * vel);
        SetStick(num++, 14.5f * vel);
        SetStick(num++, 15f * vel);
        SetStick(num++, 15.5f * vel);
        SetStick(num++, 16f * vel);
        SetStick(num++, 16.5f * vel);
        SetStick(num++, 17f * vel);
        SetStick(num++, 17.5f * vel);
        SetStick(num++, 18f * vel);
        SetStick(num++, 18.5f * vel);
        SetStick(num++, 19f * vel);
        SetStick(num++, 19.5f * vel);
        SetStick(num++, 20f * vel);
        SetStick(num++, 20.5f * vel);
        SetStick(num++, 21f * vel);
        SetStick(num++, 21.5f * vel);
        SetStick(num++, 22f * vel);
        SetStick(num++, 22.5f * vel);
        SetStick(num++, 23f * vel);
        SetStick(num++, 23.5f * vel);
        SetStick(num++, 24f * vel);
        SetStick(num++, 24.5f * vel);
        SetStick(num++, 25f * vel);
        SetStick(num++, 25.5f * vel);
        SetStick(num++, 26f * vel);
        SetStick(num++, 26.5f * vel);
        SetStick(num++, 27f * vel);
        SetStick(num++, 27.5f * vel);
        SetStick(num++, 28f * vel);
        SetStick(num++, 28.3f * vel);
        SetStick(num++, 28.7f * vel);
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
        SetStick(num++, 38f * vel);
        SetStick(num++, 38.5f * vel);
        SetStick(num++, 39f * vel);
        SetStick(num++, 39.5f * vel);
        SetStick(num++, 40f * vel);
        SetStick(num++, 40.5f * vel);
        SetStick(num++, 41f * vel);
        SetStick(num++, 41.5f * vel);
        SetStick(num++, 42f * vel);
        SetStick(num++, 42.5f * vel);
        SetStick(num++, 43f * vel);
        SetStick(num++, 43.5f * vel);
        SetStick(num++, 44f * vel);
        SetStick(num++, 44.5f * vel);
        SetStick(num++, 45f * vel);
        SetStick(num++, 45.5f * vel);
        SetStick(num++, 46f * vel);
        SetStick(num++, 46.4f * vel);
        SetStick(num++, 46.7f * vel);
        SetStick(num++, 47f * vel);
        SetStick(num++, 47.3f * vel);
        SetStick(num++, 47.7f * vel);
        SetStick(num++, 48f * vel);
        SetStick(num++, 48.5f * vel);
        SetStick(num++, 49f * vel);
        SetStick(num++, 49.5f * vel);
        SetStick(num++, 50f * vel);
        SetStick(num++, 50.5f * vel);
        SetStick(num++, 51f * vel);
        SetStick(num++, 51.5f * vel);
        SetStick(num++, 52f * vel);
        SetStick(num++, 52.5f * vel);
        SetStick(num++, 53f * vel);
        SetStick(num++, 53.5f * vel);
        SetStick(num++, 54f * vel);
        SetStick(num++, 54.5f * vel);
        SetStick(num++, 55f * vel);
        SetStick(num++, 55.5f * vel);
        SetStick(num++, 56f * vel);
        SetStick(num++, 56.5f * vel);
        SetStick(num++, 57f * vel);
        SetStick(num++, 57.5f * vel);
        SetStick(num++, 58f * vel);
        SetStick(num++, 58.5f * vel);
        SetStick(num++, 59f * vel);
        SetStick(num++, 59.5f * vel);
        SetStick(num++, 60f * vel);
        SetStick(num++, 60.5f * vel);
        SetStick(num++, 61f * vel);
        SetStick(num++, 61.5f * vel);
        SetStick(num++, 62f * vel);
        SetStick(num++, 62.5f * vel);
        SetStick(num++, 63f * vel);
        SetStick(num++, 63.5f * vel);
        SetStick(num++, 64f * vel);
        SetStick(num++, 64.5f * vel);
        SetStick(num++, 65f * vel);
        SetStick(num++, 65.5f * vel);
        SetStick(num++, 66f * vel);
        SetStick(num++, 66.5f * vel);
        SetStick(num++, 67f * vel);
        SetStick(num++, 67.5f * vel);
        SetStick(num++, 68f * vel);
        SetStick(num++, 68.5f * vel);
        SetStick(num++, 69f * vel);
        SetStick(num++, 69.5f * vel);
        SetStick(num++, 70f * vel);
        SetStick(num++, 70.5f * vel);
        SetStick(num++, 71f * vel);
        SetStick(num++, 71.5f * vel);
        SetStick(num++, 72f * vel);
        SetStick(num++, 72.5f * vel);
        SetStick(num++, 73f * vel);
        SetStick(num++, 73.5f * vel);
        SetStick(num++, 74f * vel);
        SetStick(num++, 74.5f * vel);
        SetStick(num++, 75f * vel);
        SetStick(num++, 75.5f * vel);
        SetStick(num++, 76f * vel);
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

        // --------------------------------------

        Max = num;
    }

    public override void SetEnemyData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = 0.0f;

        // Enemyコピペゾーン --------------------

        SetEnemy(num++, 5.5f * vel - error, 1 * updown, enemyTypeB);
        SetEnemy(num++, 7f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 11f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 12.5f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 18.5f * vel - error, 1 * updown, enemyTypeB);
        SetEnemy(num++, 20f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 21f * vel - error, 0 * updown, enemyTypeB);
        SetEnemy(num++, 23f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 24f * vel - error, 1 * updown, enemyTypeB);
        SetEnemy(num++, 25.5f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 26.5f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 29f * vel - error, 0 * updown, enemyTypeB);
        SetEnemy(num++, 30f * vel - error, 0 * updown, enemyTypeB);
        SetEnemy(num++, 31f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 32f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 33.5f * vel - error, -1 * updown, enemyTypeB);
        SetEnemy(num++, 33.5f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 33.5f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 36f * vel - error, 1 * updown, enemyTypeB);
        SetEnemy(num++, 37f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 38f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 38f * vel - error, 0 * updown, enemyTypeB);
        SetEnemy(num++, 38f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 42f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 44f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 45.5f * vel - error, 0 * updown, enemyTypeB);
        SetEnemy(num++, 49f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 51f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 52.5f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 55f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 56f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 60f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 61f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 63f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 63f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 63f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 65f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 66f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 71f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 72.5f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 75f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 75f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 75f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 80.5f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 80.5f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 80.5f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 85f * vel - error, 0 * updown, enemyTypeA);

        // --------------------------------------
    }

    public override void SetObstacleData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = 0.0f;

        // Obstacleコピペゾーン -----------------

        SetObstacle(num++, 2f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 3f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 4.5f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 8.5f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 10f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 13.5f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 15f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 16f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 16f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 19f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 20.5f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 21.5f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 24f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 26f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 26.5f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 30f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 31.5f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 35f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 35f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 40.5f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 40.5f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 42.5f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 46.4f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 47f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 47.7f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 51.5f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 53f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 56.5f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 57f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 58.5f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 67f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 67.5f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 68.5f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 69f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 71f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 71f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 72f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 72f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 73.5f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 76f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 76f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 77.5f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 78f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 83f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 83f * vel - error, 1 * updown, obstacleTypeA);

        // --------------------------------------
    }

    public override float SetMoveLimit()
    {
        return ((stickPosDataArray[Max - 1]) + 6.0f);
    }

    public override int GetLastStick()
    {
        return (Max - 1);
    }
}
