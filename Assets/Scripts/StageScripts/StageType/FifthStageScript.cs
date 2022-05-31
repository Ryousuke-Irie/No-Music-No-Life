using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifthStageScript : StageScript
{
    //public GameObject enemyTypeA;
    //public GameObject enemyTypeB;
    //public GameObject enemyTypeC;
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

    float bpm = 90.0f;
    private int Max = 0;

    public override void SetStickData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;

        float bpm = 90f;
        float sp = 0.16f;
        float p = 60.0f / bpm;
        float t = 1.0f;

        // Stickコピペゾーン --------------------

        SetStick(num++, (sp + (p * (t * 0))) * vel);
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
        SetStick(num++, (sp + (p * (t * 23))) * vel);
        SetStick(num++, (sp + (p * (t * 24))) * vel);
        SetStick(num++, (sp + (p * (t * 25))) * vel);
        SetStick(num++, (sp + (p * (t * 26))) * vel);
        SetStick(num++, (sp + (p * (t * 27))) * vel);
        SetStick(num++, (sp + (p * (t * 28))) * vel);
        SetStick(num++, (sp + (p * (t * 29))) * vel);
        SetStick(num++, (sp + (p * (t * 30))) * vel);
        SetStick(num++, (sp + (p * (t * 31))) * vel);
        SetStick(num++, (sp + (p * (t * 32))) * vel);
        SetStick(num++, (sp + (p * (t * 33))) * vel);
        SetStick(num++, (sp + (p * (t * 34))) * vel);
        SetStick(num++, (sp + (p * (t * 35))) * vel);
        SetStick(num++, (sp + (p * (t * 36))) * vel);
        SetStick(num++, (sp + (p * (t * 37))) * vel);
        SetStick(num++, (sp + (p * (t * 38))) * vel);
        SetStick(num++, (sp + (p * (t * 39))) * vel);
        SetStick(num++, (sp + (p * (t * 40))) * vel);
        SetStick(num++, (sp + (p * (t * 41))) * vel);
        SetStick(num++, (sp + (p * (t * 42))) * vel);
        SetStick(num++, (sp + (p * (t * 43))) * vel);
        SetStick(num++, (sp + (p * (t * 44))) * vel);
        SetStick(num++, (sp + (p * (t * 45))) * vel);
        SetStick(num++, (sp + (p * (t * 46))) * vel);
        SetStick(num++, (sp + (p * (t * 47))) * vel);
        SetStick(num++, (sp + (p * (t * 48))) * vel);
        SetStick(num++, (sp + (p * (t * 49))) * vel);
        SetStick(num++, (sp + (p * (t * 50))) * vel);
        SetStick(num++, (sp + (p * (t * 51))) * vel);
        SetStick(num++, (sp + (p * (t * 52))) * vel);
        SetStick(num++, (sp + (p * (t * 53))) * vel);
        SetStick(num++, (sp + (p * (t * 54))) * vel);
        SetStick(num++, (sp + (p * (t * 55))) * vel);
        SetStick(num++, (sp + (p * (t * 56))) * vel);
        SetStick(num++, (sp + (p * (t * 57))) * vel);
        SetStick(num++, (sp + (p * (t * 58))) * vel);
        SetStick(num++, (sp + (p * (t * 59))) * vel);
        SetStick(num++, (sp + (p * (t * 60))) * vel);
        SetStick(num++, (sp + (p * (t * 61))) * vel);
        SetStick(num++, (sp + (p * (t * 62))) * vel);
        SetStick(num++, (sp + (p * (t * 63))) * vel);
        SetStick(num++, (sp + (p * (t * 64))) * vel);
        SetStick(num++, (sp + (p * (t * 65))) * vel);
        SetStick(num++, (sp + (p * (t * 66))) * vel);
        SetStick(num++, (sp + (p * (t * 67))) * vel);
        SetStick(num++, (sp + (p * (t * 68))) * vel);
        SetStick(num++, (sp + (p * (t * 69))) * vel);
        SetStick(num++, (sp + (p * (t * 70))) * vel);
        SetStick(num++, (sp + (p * (t * 71))) * vel);
        SetStick(num++, (sp + (p * (t * 72))) * vel);
        SetStick(num++, (sp + (p * (t * 73))) * vel);
        SetStick(num++, (sp + (p * (t * 74))) * vel);

        SetStick(num++, (sp + (p * (t * 75))) * vel);
        SetStick(num++, (sp + (p * (t * 76))) * vel);
        SetStick(num++, (sp + (p * (t * 77))) * vel);
        SetStick(num++, (sp + (p * (t * 78))) * vel);
        SetStick(num++, (sp + (p * (t * 79))) * vel);
        SetStick(num++, (sp + (p * (t * 80))) * vel);
        SetStick(num++, (sp + (p * (t * 81))) * vel);
        SetStick(num++, (sp + (p * (t * 82))) * vel);
        SetStick(num++, (sp + (p * (t * 83))) * vel);
        SetStick(num++, (sp + (p * (t * 84))) * vel);
        SetStick(num++, (sp + (p * (t * 85))) * vel);
        SetStick(num++, (sp + (p * (t * 86))) * vel);
        SetStick(num++, (sp + (p * (t * 87))) * vel);
        SetStick(num++, (sp + (p * (t * 88))) * vel);
        SetStick(num++, (sp + (p * (t * 89))) * vel);
        SetStick(num++, (sp + (p * (t * 90))) * vel);
        SetStick(num++, (sp + (p * (t * 91))) * vel);
        SetStick(num++, (sp + (p * (t * 92))) * vel);
        SetStick(num++, (sp + (p * (t * 93))) * vel);
        SetStick(num++, (sp + (p * (t * 94))) * vel);
        SetStick(num++, (sp + (p * (t * 95))) * vel);
        SetStick(num++, (sp + (p * (t * 96))) * vel);
        SetStick(num++, (sp + (p * (t * 97))) * vel);
        SetStick(num++, (sp + (p * (t * 98))) * vel);
        SetStick(num++, (sp + (p * (t * 99))) * vel);
        SetStick(num++, (sp + (p * (t * 100))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 101))) * vel);

        SetStick(num++, (sp + (p * (1.01f * 102))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 103))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 104))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 105))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 106))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 107))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 108))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 109))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 110))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 111))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 112))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 113))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 114))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 115))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 116))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 117))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 118))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 119))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 121))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 122))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 123))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 124))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 125))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 126))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 127))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 128))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 129))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 130))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 131))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 132))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 133))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 134))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 135))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 136))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 137))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 138))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 139))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 140))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 141))) * vel);

        // --------------------------------------

        Max = num;
    }

    public override void SetEnemyData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        float bpm = 90f;
        float sp = 0.16f;
        float p = 60.0f / bpm;
        float t = 1.0f;

        // Enemyコピペゾーン --------------------



        // --------------------------------------
    }

    public override void SetObstacleData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        float bpm = 90f;
        float sp = 0.16f;
        float p = 60.0f / bpm;
        float t = 1.0f;

        // Obstacleコピペゾーン -----------------

        SetObstacle(num++, (sp + (p * (t * 3))) * vel - error, 1 * updown, obstacleTypeH);
        SetObstacle(num++, (sp + (p * (t * 4))) * vel - error, 0 * updown, obstacleTypeG);
        SetObstacle(num++, (sp + (p * (t * 7))) * vel - error, -1 * updown, obstacleTypeF);
        SetObstacle(num++, (sp + (p * (t * 8))) * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, (sp + (p * (t * 14))) * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, (sp + (p * (t * 17))) * vel - error, -1 * updown, obstacleTypeG);
        SetObstacle(num++, (sp + (p * (t * 18))) * vel - error, 0 * updown, obstacleTypeB);
        SetObstacle(num++, (sp + (p * (t * 19))) * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, (sp + (p * (t * 22))) * vel - error, 1 * updown, obstacleTypeH);
        SetObstacle(num++, (sp + (p * (t * 26))) * vel - error, -1 * updown, obstacleTypeF);
        SetObstacle(num++, (sp + (p * (t * 28))) * vel - error, 1 * updown, obstacleTypeE);
        SetObstacle(num++, (sp + (p * (t * 30))) * vel - error, 0 * updown, obstacleTypeG);
        SetObstacle(num++, (sp + (p * (t * 33))) * vel - error, 1 * updown, obstacleTypeC);
        SetObstacle(num++, (sp + (p * (t * 35))) * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, (sp + (p * (t * 36))) * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, (sp + (p * (t * 38))) * vel - error, 1 * updown, obstacleTypeH);
        SetObstacle(num++, (sp + (p * (t * 40))) * vel - error, 0 * updown, obstacleTypeF);
        SetObstacle(num++, (sp + (p * (t * 43))) * vel - error, 1 * updown, obstacleTypeD);
        SetObstacle(num++, (sp + (p * (t * 44))) * vel - error, 0 * updown, obstacleTypeG);
        SetObstacle(num++, (sp + (p * (t * 47))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * 49))) * vel - error, 0 * updown, obstacleTypeE);

        SetObstacle(num++, (sp + (p * (t * 54))) * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, (sp + (p * (t * 57))) * vel - error, 1 * updown, obstacleTypeH);
        SetObstacle(num++, (sp + (p * (t * 59))) * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, (sp + (p * (t * 62))) * vel - error, -1 * updown, obstacleTypeF);
        SetObstacle(num++, (sp + (p * (t * 63))) * vel - error, 1 * updown, obstacleTypeE);
        SetObstacle(num++, (sp + (p * (t * 66))) * vel - error, 0 * updown, obstacleTypeG);
        SetObstacle(num++, (sp + (p * (t * 69))) * vel - error, 1 * updown, obstacleTypeH);
        SetObstacle(num++, (sp + (p * (t * 69))) * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, (sp + (p * (t * 73))) * vel - error, -1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (t * 75))) * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, (sp + (p * (t * 78))) * vel - error, 1 * updown, obstacleTypeF);
        SetObstacle(num++, (sp + (p * (t * 81))) * vel - error, 0 * updown, obstacleTypeE);
        SetObstacle(num++, (sp + (p * (t * 83))) * vel - error, 1 * updown, obstacleTypeB);
        SetObstacle(num++, (sp + (p * (t * 86))) * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, (sp + (p * (t * 89))) * vel - error, 0 * updown, obstacleTypeD);
        SetObstacle(num++, (sp + (p * (t * 95))) * vel - error, 0 * updown, obstacleTypeG);
        SetObstacle(num++, (sp + (p * (t * 99))) * vel - error, 1 * updown, obstacleTypeC);

        SetObstacle(num++, (sp + (p * (1.01f * 101))) * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, (sp + (p * (1.01f * 104))) * vel - error, 1 * updown, obstacleTypeH);
        SetObstacle(num++, (sp + (p * (1.01f * 107))) * vel - error, -1 * updown, obstacleTypeG);
        SetObstacle(num++, (sp + (p * (1.01f * 108))) * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, (sp + (p * (1.01f * 110))) * vel - error, 1 * updown, obstacleTypeE);
        SetObstacle(num++, (sp + (p * (1.01f * 113))) * vel - error, 0 * updown, obstacleTypeF);
        SetObstacle(num++, (sp + (p * (1.01f * 117))) * vel - error, 1 * updown, obstacleTypeH);
        SetObstacle(num++, (sp + (p * (1.01f * 117))) * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, (sp + (p * (1.01f * 119))) * vel - error, -1 * updown, obstacleTypeE);
        SetObstacle(num++, (sp + (p * (1.01f * 122))) * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, (sp + (p * (1.01f * 126))) * vel - error, 1 * updown, obstacleTypeG);
        SetObstacle(num++, (sp + (p * (1.01f * 133))) * vel - error, 0 * updown, obstacleTypeI);
        SetObstacle(num++, (sp + (p * (1.01f * 138))) * vel - error, 1 * updown, obstacleTypeA);
        SetObstacle(num++, (sp + (p * (1.01f * 141))) * vel - error, 1 * updown, obstacleTypeH);

        // --------------------------------------
    }

    public override float SetMoveLimit()
    {
        // return ((stickPosDataArray[Max - 1]) + 6.0f);
        return ((stickPosDataArray[Max - 1]) + 2.0f);
    }

    public override int GetLastStick()
    {
        return (Max - 1);
    }
}
