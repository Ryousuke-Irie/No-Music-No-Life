using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStageScript : StageScript
{
    public GameObject enemyTypeA;
    public GameObject obstacleTypeA;

    private int Max = 0;

    public override void SetStickData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;

        // Stickコピペゾーン --------------------

        SetStick(num++, 0.677f * vel);
        SetStick(num++, 1.354f * vel);
        SetStick(num++, 2.031f * vel);
        SetStick(num++, 2.708f * vel);
        SetStick(num++, 3.38500f * vel);
        SetStick(num++, 4.062f * vel);
        SetStick(num++, 4.73900f * vel);
        SetStick(num++, 5.416f * vel);
        SetStick(num++, 6.093f * vel);
        SetStick(num++, 6.77f * vel);
        SetStick(num++, 7.44699f * vel);
        SetStick(num++, 8.12399f * vel);
        SetStick(num++, 8.80099f * vel);
        SetStick(num++, 9.47799f * vel);
        SetStick(num++, 10.1549f * vel);
        SetStick(num++, 10.8319f * vel);
        SetStick(num++, 11.5089f * vel);
        SetStick(num++, 12.1859f * vel);
        SetStick(num++, 12.8629f * vel);
        SetStick(num++, 13.5399f * vel);
        SetStick(num++, 14.2169f * vel);
        SetStick(num++, 14.8939f * vel);
        SetStick(num++, 15.5709f * vel);
        SetStick(num++, 16.2479f * vel);
        SetStick(num++, 16.9249f * vel);
        SetStick(num++, 17.6019f * vel);
        SetStick(num++, 18.2789f * vel);
        SetStick(num++, 18.9559f * vel);
        SetStick(num++, 19.6329f * vel);
        SetStick(num++, 20.3099f * vel);
        SetStick(num++, 20.9869f * vel);
        SetStick(num++, 21.6639f * vel);
        SetStick(num++, 22.3409f * vel);
        SetStick(num++, 23.0179f * vel);
        SetStick(num++, 23.6949f * vel);
        SetStick(num++, 24.3719f * vel);
        SetStick(num++, 25.0489f * vel);
        SetStick(num++, 25.7259f * vel);
        SetStick(num++, 26.4029f * vel);
        SetStick(num++, 27.0799f * vel);
        SetStick(num++, 27.7569f * vel);
        SetStick(num++, 28.4339f * vel);
        SetStick(num++, 29.1109f * vel);
        SetStick(num++, 29.7879f * vel);
        SetStick(num++, 30.4649f * vel);
        SetStick(num++, 31.1419f * vel);
        SetStick(num++, 31.8189f * vel);
        SetStick(num++, 32.4959f * vel);
        SetStick(num++, 33.1729f * vel);
        SetStick(num++, 33.8499f * vel);
        SetStick(num++, 34.5269f * vel);
        SetStick(num++, 35.2039f * vel);
        SetStick(num++, 35.8809f * vel);
        SetStick(num++, 36.5579f * vel);
        SetStick(num++, 37.2349f * vel);
        SetStick(num++, 37.9119f * vel);
        SetStick(num++, 38.5889f * vel);
        SetStick(num++, 39.2659f * vel);
        SetStick(num++, 39.9429f * vel);
        SetStick(num++, 40.6199f * vel);
        SetStick(num++, 41.2969f * vel);
        SetStick(num++, 41.9739f * vel);
        SetStick(num++, 42.6509f * vel);
        SetStick(num++, 43.3279f * vel);
        SetStick(num++, 44.0049f * vel);
        SetStick(num++, 44.6819f * vel);
        SetStick(num++, 45.3589f * vel);
        SetStick(num++, 46.0359f * vel);
        SetStick(num++, 46.7129f * vel);
        SetStick(num++, 47.3899f * vel);
        SetStick(num++, 48.0669f * vel);
        SetStick(num++, 48.7439f * vel);
        SetStick(num++, 49.4209f * vel);
        SetStick(num++, 50.0979f * vel);
        SetStick(num++, 50.7749f * vel);
        SetStick(num++, 51.4519f * vel);
        SetStick(num++, 52.1289f * vel);
        SetStick(num++, 52.8059f * vel);
        SetStick(num++, 53.4829f * vel);
        SetStick(num++, 54.1599f * vel);
        SetStick(num++, 54.8369f * vel);
        SetStick(num++, 55.5139f * vel);
        SetStick(num++, 56.1909f * vel);
        SetStick(num++, 56.8679f * vel);
        SetStick(num++, 57.5449f * vel);
        SetStick(num++, 58.2219f * vel);
        SetStick(num++, 58.8989f * vel);
        SetStick(num++, 59.5759f * vel);
        SetStick(num++, 60.2529f * vel);
        SetStick(num++, 60.9299f * vel);
        SetStick(num++, 61.6069f * vel);
        SetStick(num++, 62.2839f * vel);
        SetStick(num++, 62.9609f * vel);
        SetStick(num++, 63.6379f * vel);
        SetStick(num++, 64.3149f * vel);
        SetStick(num++, 64.9919f * vel);
        SetStick(num++, 65.6689f * vel);
        SetStick(num++, 66.3459f * vel);
        SetStick(num++, 67.023f * vel);
        SetStick(num++, 67.7f * vel);
        SetStick(num++, 68.3770f * vel);
        SetStick(num++, 69.0540f * vel);
        SetStick(num++, 69.7310f * vel);
        SetStick(num++, 70.4080f * vel);
        SetStick(num++, 71.0850f * vel);
        SetStick(num++, 71.7620f * vel);
        SetStick(num++, 72.4390f * vel);
        SetStick(num++, 73.1160f * vel);
        SetStick(num++, 73.7930f * vel);
        SetStick(num++, 74.4700f * vel);
        SetStick(num++, 75.1470f * vel);
        SetStick(num++, 75.8240f * vel);
        SetStick(num++, 76.5010f * vel);
        SetStick(num++, 77.1780f * vel);
        SetStick(num++, 77.8550f * vel);
        SetStick(num++, 78.5320f * vel);
        SetStick(num++, 79.2090f * vel);
        SetStick(num++, 79.8860f * vel);
        SetStick(num++, 80.5630f * vel);
        SetStick(num++, 81.2400f * vel);
        SetStick(num++, 81.9170f * vel);
        SetStick(num++, 82.5940f * vel);
        SetStick(num++, 83.2710f * vel);
        SetStick(num++, 83.9480f * vel);
        SetStick(num++, 84.6250f * vel);
        SetStick(num++, 85.3020f * vel);
        SetStick(num++, 85.9790f * vel);
        SetStick(num++, 86.6560f * vel);
        SetStick(num++, 87.3330f * vel);
        SetStick(num++, 88.0100f * vel);
        SetStick(num++, 88.6870f * vel);
        SetStick(num++, 89.3640f * vel);
        SetStick(num++, 90.0410f * vel);
        SetStick(num++, 90.7180f * vel);
        SetStick(num++, 91.3950f * vel);
        SetStick(num++, 92.0720f * vel);
        SetStick(num++, 92.7490f * vel);
        SetStick(num++, 93.4260f * vel);
        SetStick(num++, 94.1030f * vel);
        SetStick(num++, 94.7800f * vel);
        SetStick(num++, 95.4570f * vel);
        SetStick(num++, 96.1340f * vel);
        SetStick(num++, 96.8110f * vel);
        SetStick(num++, 97.4880f * vel);
        SetStick(num++, 98.1650f * vel);
        SetStick(num++, 98.8420f * vel);
        SetStick(num++, 99.5190f * vel);
        SetStick(num++, 100.196f * vel);
        SetStick(num++, 100.873f * vel);
        SetStick(num++, 101.550f * vel);
        SetStick(num++, 102.227f * vel);
        SetStick(num++, 102.904f * vel);
        SetStick(num++, 103.581f * vel);
        SetStick(num++, 104.258f * vel);
        SetStick(num++, 104.935f * vel);
        SetStick(num++, 105.612f * vel);
        SetStick(num++, 106.289f * vel);
        SetStick(num++, 106.966f * vel);
        SetStick(num++, 107.643f * vel);
        SetStick(num++, 108.320f * vel);
        SetStick(num++, 108.997f * vel);
        SetStick(num++, 109.674f * vel);
        SetStick(num++, 110.351f * vel);
        SetStick(num++, 111.028f * vel);
        SetStick(num++, 111.705f * vel);
        SetStick(num++, 112.382f * vel);
        SetStick(num++, 113.059f * vel);
        SetStick(num++, 113.736f * vel);
        SetStick(num++, 114.413f * vel);
        SetStick(num++, 115.090f * vel);
        SetStick(num++, 115.767f * vel);
        SetStick(num++, 116.444f * vel);
        SetStick(num++, 117.121f * vel);
        SetStick(num++, 117.798f * vel);
        SetStick(num++, 118.475f * vel);
        SetStick(num++, 119.152f * vel);
        SetStick(num++, 119.829f * vel);
        SetStick(num++, 120.506f * vel);
        SetStick(num++, 121.183f * vel);
        SetStick(num++, 121.860f * vel);
        SetStick(num++, 122.537f * vel);
        SetStick(num++, 123.214f * vel);
        SetStick(num++, 123.891f * vel);

        // --------------------------------------

        Max = num;
    }

    public override void SetEnemyData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = 0.7f;

    // Enemyコピペゾーン --------------------

    SetEnemy(num++, 4.062f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 6.77f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 9.47799f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 12.8629f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 14.8939f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 17.6019f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 18.9559f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 20.9869f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 22.3409f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 25.7259f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 28.4339f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 31.1419f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 34.5269f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 37.2349f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 39.9429f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 43.3279f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 46.7129f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 49.4209f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 52.1289f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 54.8369f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 57.5449f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 58.8989f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 60.9299f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 63.6379f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 64.9919f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 68.3770f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 71.7620f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 73.1160f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 74.4700f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 76.5010f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 77.8550f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 79.8860f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 82.5940f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 83.9480f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 85.3020f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 87.3330f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 88.6870f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 90.0410f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 92.0720f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 93.4260f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 94.7800f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 96.8110f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 99.5190f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 102.227f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 105.612f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 108.320f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 111.028f * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, 113.736f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 116.444f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 117.798f * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, 120.506f * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, 123.214f * vel - error, -1 * updown, enemyTypeA);

        // --------------------------------------
    }

    public override void SetObstacleData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = 0.0f;

        // Obstacleコピペゾーン -----------------

        SetObstacle(num++, 5.416f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 8.12399f * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, 10.1549f * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, 12.1859f * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, 12.1859f * vel - error, -1 * updown, obstacleTypeA);

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
