using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStageScript : StageScript
{
    public GameObject enemyTypeA;
    public GameObject obstacleTypeA;

    public override void SetStickData() 
    {
        for(int i = 0; i < 183; i++)
        {
            SetStick(i, (i + 1) * 6.0f);
        }
    }

    public override void SetEnemyData() 
    {
        int num = 0;
        SetEnemy(num++, 6 * 6.0f -0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 10 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 14 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 19 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 22 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 26 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 28 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 31 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 33 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 38 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 42 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 46 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 51 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 55 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 59 * 6.0f - 0.7f, 0.0f, enemyTypeA);

        SetEnemy(num++, 64 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 69 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 73 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 77 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 81 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 85 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 87 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 90 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 94 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 96 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 101 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 106 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 108 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 110 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 113 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 115 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 118 * 6.0f - 0.7f, 4.0f, enemyTypeA);

        SetEnemy(num++, 122 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 124 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 126 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 129 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 131 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 133 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 136 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 138 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 140 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 143 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 147 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 151 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 156 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 160 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 164 * 6.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, 168 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 172 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 174 * 6.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, 178 * 6.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, 182 * 6.0f - 0.7f, -4.0f, enemyTypeA);
    }

    public override void SetObstacleData() 
    {
        int num = 0;
        SetObstacle(num++, 8 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 12 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 15 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 18 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 18 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 22 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 27 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 28 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 33 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 33 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 38 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 38 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 42 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 42 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 46 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 46 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 50 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 53 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 55 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 58 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 60 * 6.0f, -4.0f, obstacleTypeA);

        SetObstacle(num++, 62 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 63 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 65 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 68 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 69 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 75 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 75 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 81 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 86 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 86 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 90 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 95 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 96 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 101 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 101 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 106 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 106 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 110 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 113 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 118 * 6.0f, -4.0f, obstacleTypeA);

        SetObstacle(num++, 123 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 124 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 125 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 130 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 130 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 132 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 132 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 137 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 138 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 139 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 145 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 146 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 150 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 151 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 156 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 156 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 158 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 160 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 163 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 164 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 168 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 170 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 173 * 6.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, 174 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 177 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 179 * 6.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, 179 * 6.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, 183 * 6.0f, -4.0f, obstacleTypeA);
    }

    public override float SetMoveLimit()
    {
        return (184 * 6.0f);
    }

    public override int GetLastStick()
    {
        return (182);
    }
}
