using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStageScript : StageScript
{
    private int Max = 0;

    public override void SetStickData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;

        float bpm = 120f;
        float sp = 0.0f;
        float p = 60.0f / bpm;
        float t = 1.0f;

        // Stick�R�s�y�]�[�� --------------------

        for (int i = 0; i < 120; i++)
        {
            SetStick(i, (sp + (p * (t * (i + 1)))) * vel);
        }

        // --------------------------------------

        Max = 120;
    }

    public override void SetEnemyData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        // Enemy�R�s�y�]�[�� --------------------



        // --------------------------------------
    }

    public override void SetObstacleData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        // Obstacle�R�s�y�]�[�� -----------------



        // --------------------------------------
    }

    public override float SetMoveLimit()
    {
        // return ((stickPosDataArray[Max - 1]) + 6.0f);
        return ((stickPosDataArray[Max - 1]) + 6.0f);
    }

    public override int GetLastStick()
    {
        return (Max - 1);
    }
}
