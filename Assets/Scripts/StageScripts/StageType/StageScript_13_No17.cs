using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript_13_No17 : StageScript
{
    public GameObject enemyTypeA;
    public GameObject enemyTypeS;
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
    public GameObject obstacleTypeK;

    private int Max = 0;

    public override void SetStickData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;

        // Stick�R�s�y�]�[�� --------------------
        //38  40�A��
        //42  44
        //46  48
        //108  117
        float bpm = 105;
        float sp = 0.10f;
        float p = 60.0f / bpm;
        float t = 1.0f;

       //SetStick(num++, (sp + (p * (t * 0))) * vel);
       //SetStick(num++, (sp + (p * (t * 1))) * vel);
       //SetStick(num++, (sp + (p * (t * 2))) * vel);
       //SetStick(num++, (sp + (p * (t * 3))) * vel);

        SetStick(num++, (sp + (p * (t * 4))) * vel);
        SetStick(num++, (sp + (p * (t * 5))) * vel);
        SetStick(num++, (sp + (p * (t * 6))) * vel);
      //  SetStick(num++, (sp + (p * (t * 7))) * vel);
      //  SetStick(num++, (sp + (p * (t * 8))) * vel);
        SetStick(num++, (sp + (p * (t * 9))) * vel);
      //  SetStick(num++, (sp + (p * (t * 10))) * vel);
        SetStick(num++, (sp + (p * (t * 11))) * vel);
       // SetStick(num++, (sp + (p * (t * 12))) * vel);
        SetStick(num++, (sp + (p * (t * 13))) * vel);
      //  SetStick(num++, (sp + (p * (t * 14))) * vel);
     //   SetStick(num++, (sp + (p * (t * 15))) * vel);
      //  SetStick(num++, (sp + (p * (t * 16))) * vel);
        SetStick(num++, (sp + (p * (t * 17))) * vel);
      //  SetStick(num++, (sp + (p * (t * 18))) * vel);
     //   SetStick(num++, (sp + (p * (t * 19))) * vel);
       // SetStick(num++, (sp + (p * (t * 20))) * vel);
        SetStick(num++, (sp + (p * (t * 21))) * vel);
        SetStick(num++, (sp + (p * (t * 22))) * vel);
       // SetStick(num++, (sp + (p * (t * 23))) * vel);
        SetStick(num++, (sp + (p * (t * 24))) * vel);
     //   SetStick(num++, (sp + (p * (t * 25))) * vel);
        SetStick(num++, (sp + (p * (t * 26))) * vel);
        SetStick(num++, (sp + (p * (t * 27))) * vel);
        SetStick(num++, (sp + (p * (t * 28))) * vel);
     //   SetStick(num++, (sp + (p * (t * 29))) * vel);
        SetStick(num++, (sp + (p * (t * 30))) * vel);
        SetStick(num++, (sp + (p * (t * 31))) * vel);
     //   SetStick(num++, (sp + (p * (t * 32))) * vel);
        SetStick(num++, (sp + (p * (t * 33))) * vel); //10
        SetStick(num++, (sp + (p * (t * 34))) * vel);
        SetStick(num++, (sp + (p * (t * 35))) * vel);
        SetStick(num++, (sp + (p * (t * 36))) * vel);


       // SetStick(num++, (sp + (p * (t * 37))) * vel);

        SetStick(num++, (sp + (p * (t * 38))) * vel);
        SetStick(num++, (sp + (p * (t * 39))) * vel);
        SetStick(num++, (sp + (p * (t * 40))) * vel);

       // SetStick(num++, (sp + (p * (t * 41))) * vel);
        SetStick(num++, (sp + (p * (t * 42))) * vel); 
        SetStick(num++, (sp + (p * (t * 43))) * vel);  //20
        SetStick(num++, (sp + (p * (t * 44))) * vel);
        //SetStick(num++, (sp + (p * (t * 45))) * vel);
       
        SetStick(num++, (sp + (p * (t * 46))) * vel);
        SetStick(num++, (sp + (p * (t * 47))) * vel);
        SetStick(num++, (sp + (p * (t * 48))) * vel);
       
        //  SetStick(num++, (sp + (p * (t * 49))) * vel);
        SetStick(num++, (sp + (p * (t * 50))) * vel);
      //  SetStick(num++, (sp + (p * (t * 51))) * vel);
        SetStick(num++, (sp + (p * (t * 52))) * vel);
      //  SetStick(num++, (sp + (p * (t * 53))) * vel);  //30
        SetStick(num++, (sp + (p * (t * 54))) * vel);
     //   SetStick(num++, (sp + (p * (t * 55))) * vel);
        SetStick(num++, (sp + (p * (t * 56))) * vel);
     //   SetStick(num++, (sp + (p * (t * 57))) * vel);
        SetStick(num++, (sp + (p * (t * 58))) * vel);
      // SetStick(num++, (sp + (p * (t * 59))) * vel);
      // SetStick(num++, (sp + (p * (t * 60))) * vel);
      // SetStick(num++, (sp + (p * (t * 61))) * vel);

        SetStick(num++, (sp + (p * (t * 62))) * vel);
      //  SetStick(num++, (sp + (p * (t * 63))) * vel);   //40
        SetStick(num++, (sp + (p * (t * 64))) * vel);
       // SetStick(num++, (sp + (p * (t * 65))) * vel);
        SetStick(num++, (sp + (p * (t * 66))) * vel);
        SetStick(num++, (sp + (p * (t * 67))) * vel);
        SetStick(num++, (sp + (p * (t * 68))) * vel);
        SetStick(num++, (sp + (p * (t * 69))) * vel);
       // SetStick(num++, (sp + (p * (t * 70))) * vel);
        SetStick(num++, (sp + (p * (t * 71))) * vel);
        SetStick(num++, (sp + (p * (t * 72))) * vel);
        SetStick(num++, (sp + (p * (t * 73))) * vel);
        SetStick(num++, (sp + (p * (t * 74))) * vel);    //50
       // SetStick(num++, (sp + (p * (t * 75))) * vel);
        SetStick(num++, (sp + (p * (t * 76))) * vel);
        SetStick(num++, (sp + (p * (t * 77))) * vel);
      //  SetStick(num++, (sp + (p * (t * 78))) * vel);
        SetStick(num++, (sp + (p * (t * 79))) * vel);
        SetStick(num++, (sp + (p * (t * 80))) * vel);
        SetStick(num++, (sp + (p * (t * 81))) * vel);
      //  SetStick(num++, (sp + (p * (t * 82))) * vel);
        SetStick(num++, (sp + (p * (t * 83))) * vel);
        SetStick(num++, (sp + (p * (t * 84))) * vel);    //60
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
        SetStick(num++, (sp + (p * (t * 96))) * vel);   //70
        SetStick(num++, (sp + (p * (t * 97))) * vel);
       // SetStick(num++, (sp + (p * (t * 98))) * vel);
      
        SetStick(num++, (sp + (p * (t * 99))) * vel);
        SetStick(num++, (sp + (p * (t * 100))) * vel);
        SetStick(num++, (sp + (p * (t * 101))) * vel);
        SetStick(num++, (sp + (p * (t * 102))) * vel);
        SetStick(num++, (sp + (p * (t * 103))) * vel);
        SetStick(num++, (sp + (p * (t * 104))) * vel);
        SetStick(num++, (sp + (p * (t * 105))) * vel);
        SetStick(num++, (sp + (p * (t * 106))) * vel);  //80
     
        //  SetStick(num++, (sp + (p * (t * 107))) * vel);
       
        SetStick(num++, (sp + (p * (t * 108))) * vel);
        SetStick(num++, (sp + (p * (t * 109))) * vel);
        SetStick(num++, (sp + (p * (t * 110))) * vel);
        SetStick(num++, (sp + (p * (t * 111))) * vel);
        SetStick(num++, (sp + (p * (t * 112))) * vel);
        SetStick(num++, (sp + (p * (t * 113))) * vel);
        SetStick(num++, (sp + (p * (t * 114))) * vel);
        SetStick(num++, (sp + (p * (t * 115))) * vel);
        SetStick(num++, (sp + (p * (t * 116))) * vel);   //90
        SetStick(num++, (sp + (p * (t * 117))) * vel);
       
        SetStick(num++, (sp + (p * (t * 119))) * vel);
        SetStick(num++, (sp + (p * (t * 120))) * vel);
        SetStick(num++, (sp + (p * (t * 121))) * vel);
     
        // SetStick(num++, (sp + (p * (t * 122))) * vel);
        //SetStick(num++, (sp + (p * (t * 123))) * vel);
       
        // --------------------------------------

        Max = num;
    }

    public override void SetEnemyData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        float bpm = 105;
        float sp = 0.10f;
        float p = 60.0f / bpm;
        float t = 1.0f;
        // Enemy�R�s�y�]�[�� --------------------
        //38  40
        //42  44
        //46  48
        //108  117
        SetEnemy(num++, (sp + (p * (t * 4))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 5))) * vel - error, 0 * updown, enemyTypeS);
        SetEnemy(num++, (sp + (p * (t * 6))) * vel - error,0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 9))) * vel - error, 0 * updown, enemyTypeS);
        SetEnemy(num++, (sp + (p * (t * 11))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 13))) * vel - error, 0 * updown, enemyTypeS);
        SetEnemy(num++, (sp + (p * (t * 17))) * vel - error, 0 * updown, enemyTypeS);
        SetEnemy(num++, (sp + (p * (t * 22))) * vel - error, 1 * updown, enemyTypeS);

       
        SetEnemy(num++, (sp + (p * (t * 26))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 27))) * vel - error, -1 * updown, enemyTypeA);  //10
        SetEnemy(num++, (sp + (p * (t * 28))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 31))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 36))) * vel - error, 0 * updown, enemyTypeS);
        SetEnemy(num++, (sp + (p * (t * 39))) * vel - error, 1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 42))) * vel - error, -1 * updown, enemyTypeS);
        SetEnemy(num++, (sp + (p * (t * 44))) * vel - error, 0 * updown, enemyTypeS);
        SetEnemy(num++, (sp + (p * (t * 47))) * vel - error, 1 * updown, enemyTypeS);

        SetEnemy(num++, (sp + (p * (t * 56))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 58))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 64))) * vel - error, 1 * updown, enemyTypeS);
        
        SetEnemy(num++, (sp + (p * (t * 66))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 69))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 71))) * vel - error, 0 * updown, enemyTypeA);    //20
        SetEnemy(num++, (sp + (p * (t * 73))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 76))) * vel - error, 0 * updown, enemyTypeS);
        SetEnemy(num++, (sp + (p * (t * 77))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 79))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 81))) * vel - error, -1 * updown, enemyTypeA);
       
        SetEnemy(num++, (sp + (p * (t * 83))) * vel - error,1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 87))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 89))) * vel - error, -1 * updown, enemyTypeS);
        SetEnemy(num++, (sp + (p * (t * 93))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 95))) * vel - error, 0 * updown, enemyTypeS);    //30
        SetEnemy(num++, (sp + (p * (t * 97))) * vel - error, 0 * updown, enemyTypeA);
       
        SetEnemy(num++, (sp + (p * (t * 99))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 103))) * vel - error, 0 * updown, enemyTypeS);
        SetEnemy(num++, (sp + (p * (t * 105))) * vel - error, -1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 108))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 110))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 113))) * vel - error, -1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 117))) * vel - error, 0 * updown, enemyTypeA);

        // --------------------------------------
    }

    public override void SetObstacleData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        float bpm = 105;
        float sp = 0.10f;
        float p = 60.0f / bpm;
        float t = 1.0f;

        // Obstacle�R�s�y�]�[�� -----------------

        SetObstacle(num++, (sp + (p * (t * 9))) * vel - error, 1 * updown, obstacleTypeI);
        SetObstacle(num++, (sp + (p * (t * 11))) * vel - error, -1 * updown, obstacleTypeB);
        SetObstacle(num++, (sp + (p * (t * 13))) * vel - error, 1 * updown, obstacleTypeE);
       
        SetObstacle(num++, (sp + (p * (t * 24))) * vel - error, -1 * updown, obstacleTypeK);
        SetObstacle(num++, (sp + (p * (t * 26))) * vel - error, 0 * updown, obstacleTypeF);
        SetObstacle(num++, (sp + (p * (t * 30))) * vel - error, 1 * updown, obstacleTypeG);
        SetObstacle(num++, (sp + (p * (t * 33))) * vel - error, -1 * updown, obstacleTypeC);
        SetObstacle(num++, (sp + (p * (t * 34))) * vel - error, 1 * updown, obstacleTypeA);

        SetObstacle(num++, (sp + (p * (t * 50))) * vel - error, -1 * updown, obstacleTypeH);
        SetObstacle(num++, (sp + (p * (t * 52))) * vel - error,0 * updown, obstacleTypeJ);
        SetObstacle(num++, (sp + (p * (t * 54))) * vel - error, 1 * updown, obstacleTypeB);
        SetObstacle(num++, (sp + (p * (t * 62))) * vel - error, -1 * updown, obstacleTypeD);
       
        SetObstacle(num++, (sp + (p * (t * 68))) * vel - error, 0 * updown, obstacleTypeJ);   //10
        SetObstacle(num++, (sp + (p * (t * 72))) * vel - error, 1 * updown, obstacleTypeI);
        SetObstacle(num++, (sp + (p * (t * 74))) * vel - error, 0 * updown, obstacleTypeH);
        SetObstacle(num++, (sp + (p * (t * 80))) * vel - error, 0 * updown, obstacleTypeA);
        
        SetObstacle(num++, (sp + (p * (t * 84))) * vel - error, 1 * updown, obstacleTypeC);
        SetObstacle(num++, (sp + (p * (t * 88))) * vel - error, 1 * updown, obstacleTypeE);
        SetObstacle(num++, (sp + (p * (t * 91))) * vel - error, -1 * updown, obstacleTypeF);
        SetObstacle(num++, (sp + (p * (t * 94))) * vel - error, 1 * updown, obstacleTypeG);
        SetObstacle(num++, (sp + (p * (t * 96))) * vel - error, -1 * updown, obstacleTypeD);
      
        SetObstacle(num++, (sp + (p * (t * 100))) * vel - error, -1 * updown, obstacleTypeJ);
        SetObstacle(num++, (sp + (p * (t * 101))) * vel - error, 0 * updown, obstacleTypeE);   //20
        SetObstacle(num++, (sp + (p * (t * 106))) * vel - error, 1 * updown, obstacleTypeB);
       
        SetObstacle(num++, (sp + (p * (t * 119))) * vel - error, -1 * updown, obstacleTypeC);
       
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
