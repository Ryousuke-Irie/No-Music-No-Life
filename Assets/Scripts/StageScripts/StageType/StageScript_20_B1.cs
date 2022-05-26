using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript_20_B1 : StageScript
{
    //public GameObject enemyTypeA;
    //public GameObject enemyTypeB;
    public GameObject obstacleTypeA;

    private int Max = 0;

    public override void SetStickData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;

        float bpm = 120.0f;
        float sp = 0.0f;
        float p = 60 / bpm;
        float t = 1.0f;
        // Stickコピペゾーン --------------------

        //SetStick(num++, (sp + (p * (t * 0))) * vel);
        SetStick(num++, (sp + (p * (t * 1))) * vel);
        SetStick(num++, (sp + (p * (t * 2))) * vel);
        SetStick(num++, (sp + (p * (t * 3))) * vel);
        SetStick(num++, (sp + (p * (t * 4))) * vel);
        SetStick(num++, (sp + (p * (t * 5))) * vel);
        SetStick(num++, (sp + (p * (t * 6))) * vel);
        SetStick(num++, (sp + (p * (t * 7))) * vel);
        SetStick(num++, (sp + (p * (t * 8))) * vel);
        SetStick(num++, (sp + (p * (t * 9))) * vel);
        SetStick(num++, (sp + (p * (t * 10))) * vel);
        SetStick(num++, (sp + (p * (t * 11))) * vel);
        SetStick(num++, (sp + (p * (t * 12))) * vel);
        SetStick(num++, (sp + (p * (t * 13))) * vel);
        SetStick(num++, (sp + (p * (t * 14))) * vel);
        SetStick(num++, (sp + (p * (t * 15))) * vel);
        SetStick(num++, (sp + (p * (t * 16))) * vel);
        SetStick(num++, (sp + (p * (t * 17))) * vel);
        SetStick(num++, (sp + (p * (t * 18))) * vel);
        SetStick(num++, (sp + (p * (t * 19))) * vel);
        SetStick(num++, (sp + (p * (t * 20))) * vel);
        SetStick(num++, (sp + (p * (t * 21))) * vel);
        SetStick(num++, (sp + (p * (t * 22))) * vel);
        //SetStick(num++, (sp + (p * (t * 23))) * vel);

        // --------------------------------------

        Max = num;
    }

    public override void SetEnemyData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        // Enemyコピペゾーン --------------------

        // --------------------------------------
    }

    public override void SetObstacleData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        float bpm = 120.0f;
        float sp = 0.0f;
        float p = 60 / bpm;
        float t = 1.0f;
        // Obstacleコピペゾーン -----------------

        SetObstacle(num++, (sp + (p * (t * 2))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * 5))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * 9))) * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * 12))) * vel - error, 0 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * 15))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * 19))) * vel - error, -1 * updown, obstacleTypeA);

        // --------------------------------------
    }

    public override float SetMoveLimit()
    {
        // return ((stickPosDataArray[Max - 1]) + 6.0f);
        return ((stickPosDataArray[Max - 1] + 2.5f));
    }

    public override int GetLastStick()
    {
        return (Max - 1);
    }
}
