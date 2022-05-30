using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript_15 : StageScript
{
    public GameObject enemyTypeA;    //í èÌÇÃìG
    public GameObject enemyTypeB;    //ï™óÙÇ∑ÇÈìG
    public GameObject enemyTypeC;    //ãêëÂâªÇ∑ÇÈìG
    public GameObject obstacleTypeA; //í èÌÇÃè·äQï®
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

        float bpm = 120.0f;
        float sp = -0.15f;
        float p = 30 / bpm;
        float t = 1.0f;

        // StickÉRÉsÉyÉ]Å[Éì --------------------

        //SetStick(num++, (sp + (p * (t * 0))) * vel);
        SetStick(num++, (sp + (p * (t * 1))) * vel);
        //SetStick(num++, (sp + (p * (t * 2))) * vel);
        SetStick(num++, (sp + (p * (t * 3))) * vel);
        SetStick(num++, (sp + (p * (t * 4))) * vel);
        SetStick(num++, (sp + (p * (t * 5))) * vel);
        SetStick(num++, (sp + (p * (t * 6))) * vel);
        SetStick(num++, (sp + (p * (t * 7))) * vel);
        //SetStick(num++, (sp + (p * (t * 8))) * vel);
        SetStick(num++, (sp + (p * (t * 9))) * vel);
        //SetStick(num++, (sp + (p * (t * 10))) * vel);
        //SetStick(num++, (sp + (p * (t * 11))) * vel);
        //SetStick(num++, (sp + (p * (t * 12))) * vel);
        SetStick(num++, (sp + (p * (t * 13))) * vel);
        //SetStick(num++, (sp + (p * (t * 14))) * vel);
        SetStick(num++, (sp + (p * (t * 15))) * vel);
        SetStick(num++, (sp + (p * (t * 16))) * vel);
        SetStick(num++, (sp + (p * (t * 17))) * vel);
        SetStick(num++, (sp + (p * (t * 18))) * vel);
        SetStick(num++, (sp + (p * (t * 19))) * vel);
        //SetStick(num++, (sp + (p * (t * 20))) * vel);
        SetStick(num++, (sp + (p * (t * 21))) * vel);
        //SetStick(num++, (sp + (p * (t * 22))) * vel);
        //SetStick(num++, (sp + (p * (t * 23))) * vel);
        //SetStick(num++, (sp + (p * (t * 24))) * vel);
        SetStick(num++, (sp + (p * (t * 25))) * vel);
        //SetStick(num++, (sp + (p * (t * 26))) * vel);
        SetStick(num++, (sp + (p * (t * 27))) * vel);
        SetStick(num++, (sp + (p * (t * 28))) * vel);
        SetStick(num++, (sp + (p * (t * 29))) * vel);
        SetStick(num++, (sp + (p * (t * 30))) * vel);
        SetStick(num++, (sp + (p * (t * 31))) * vel);
        //SetStick(num++, (sp + (p * (t * 32))) * vel);
        SetStick(num++, (sp + (p * (t * 33))) * vel);
        //SetStick(num++, (sp + (p * (t * 34))) * vel);
        SetStick(num++, (sp + (p * (t * 35))) * vel);
        //SetStick(num++, (sp + (p * (t * 36))) * vel);
        SetStick(num++, (sp + (p * (t * 37))) * vel);
        SetStick(num++, (sp + (p * (t * 38))) * vel);
        SetStick(num++, (sp + (p * (t * 39))) * vel);
        //SetStick(num++, (sp + (p * (t * 40))) * vel);
        //SetStick(num++, (sp + (p * (t * 41))) * vel);
        //SetStick(num++, (sp + (p * (t * 42))) * vel);
        SetStick(num++, (sp + (p * (t * 43))) * vel);
        //SetStick(num++, (sp + (p * (t * 44))) * vel);
        //SetStick(num++, (sp + (p * (t * 45))) * vel);
        SetStick(num++, (sp + (p * (t * 46))) * vel);
        //SetStick(num++, (sp + (p * (t * 47))) * vel);
        //SetStick(num++, (sp + (p * (t * 48))) * vel);
        SetStick(num++, (sp + (p * (t * 49))) * vel);
        //SetStick(num++, (sp + (p * (t * 50))) * vel);
        SetStick(num++, (sp + (p * (t * 51))) * vel);
        SetStick(num++, (sp + (p * (t * 52))) * vel);
        SetStick(num++, (sp + (p * (t * 53))) * vel);
        SetStick(num++, (sp + (p * (t * 54))) * vel);
        SetStick(num++, (sp + (p * (t * 55))) * vel);
        //SetStick(num++, (sp + (p * (t * 56))) * vel);
        SetStick(num++, (sp + (p * (t * 57))) * vel);
        //SetStick(num++, (sp + (p * (t * 58))) * vel);
        SetStick(num++, (sp + (p * (t * 59))) * vel);
        //SetStick(num++, (sp + (p * (t * 60))) * vel);
        SetStick(num++, (sp + (p * (t * 61))) * vel);
        //SetStick(num++, (sp + (p * (t * 62))) * vel);
        //SetStick(num++, (sp + (p * (t * 63))) * vel);
        SetStick(num++, (sp + (p * (t * 64))) * vel);
        SetStick(num++, (sp + (p * (t * 65))) * vel);
        SetStick(num++, (sp + (p * (t * 66))) * vel);
        SetStick(num++, (sp + (p * (t * 67))) * vel);
        //SetStick(num++, (sp + (p * (t * 68))) * vel);
        SetStick(num++, (sp + (p * (t * 69))) * vel);
        //SetStick(num++, (sp + (p * (t * 70))) * vel);
        SetStick(num++, (sp + (p * (t * 71))) * vel);
        //SetStick(num++, (sp + (p * (t * 72))) * vel);
        SetStick(num++, (sp + (p * (t * 73))) * vel);
        //SetStick(num++, (sp + (p * (t * 74))) * vel);
        SetStick(num++, (sp + (p * (t * 75))) * vel);
        SetStick(num++, (sp + (p * (t * 76))) * vel);
        SetStick(num++, (sp + (p * (t * 77))) * vel);
        SetStick(num++, (sp + (p * (t * 78))) * vel);
        SetStick(num++, (sp + (p * (t * 79))) * vel);
        //SetStick(num++, (sp + (p * (t * 80))) * vel);
        SetStick(num++, (sp + (p * (t * 81))) * vel);
        //SetStick(num++, (sp + (p * (t * 82))) * vel);
        SetStick(num++, (sp + (p * (t * 83))) * vel);
        //SetStick(num++, (sp + (p * (t * 84))) * vel);
        SetStick(num++, (sp + (p * (t * 85))) * vel);
        //SetStick(num++, (sp + (p * (t * 86))) * vel);
        //SetStick(num++, (sp + (p * (t * 87))) * vel);
        //SetStick(num++, (sp + (p * (t * 88))) * vel);
        SetStick(num++, (sp + (p * (t * 89))) * vel);
        //SetStick(num++, (sp + (p * (t * 90))) * vel);
        SetStick(num++, (sp + (p * (t * 91))) * vel);
        //SetStick(num++, (sp + (p * (t * 92))) * vel);
        //SetStick(num++, (sp + (p * (t * 93))) * vel);
        //SetStick(num++, (sp + (p * (t * 94))) * vel);
        //SetStick(num++, (sp + (p * (t * 95))) * vel);
        //SetStick(num++, (sp + (p * (t * 96))) * vel);
        SetStick(num++, (sp + (p * (t * 97))) * vel);
        //SetStick(num++, (sp + (p * (t * 98))) * vel);
        //SetStick(num++, (sp + (p * (t * 99))) * vel);
        SetStick(num++, (sp + (p * (t * 100))) * vel);
        //SetStick(num++, (sp + (p * (t * 101))) * vel);
        //SetStick(num++, (sp + (p * (t * 102))) * vel);
        SetStick(num++, (sp + (p * (t * 103))) * vel);
        //SetStick(num++, (sp + (p * (t * 104))) * vel);
        SetStick(num++, (sp + (p * (t * 105))) * vel);
        SetStick(num++, (sp + (p * (t * 106))) * vel);
        SetStick(num++, (sp + (p * (t * 107))) * vel);
        //SetStick(num++, (sp + (p * (t * 108))) * vel);
        SetStick(num++, (sp + (p * (t * 109))) * vel);
        //SetStick(num++, (sp + (p * (t * 110))) * vel);
        SetStick(num++, (sp + (p * (t * 111))) * vel);
        SetStick(num++, (sp + (p * (t * 112))) * vel);
        //SetStick(num++, (sp + (p * (t * 113))) * vel);
        //SetStick(num++, (sp + (p * (t * 114))) * vel);
        SetStick(num++, (sp + (p * (t * 115))) * vel);
        //SetStick(num++, (sp + (p * (t * 116))) * vel);
        SetStick(num++, (sp + (p * (t * 117))) * vel);
        SetStick(num++, (sp + (p * (t * 118))) * vel);
        SetStick(num++, (sp + (p * (t * 119))) * vel);
        //SetStick(num++, (sp + (p * (t * 120))) * vel);
        SetStick(num++, (sp + (p * (t * 121))) * vel);
        //SetStick(num++, (sp + (p * (t * 122))) * vel);
        //SetStick(num++, (sp + (p * (t * 123))) * vel);
        SetStick(num++, (sp + (p * (t * 124))) * vel);
        //SetStick(num++, (sp + (p * (t * 125))) * vel);
        //SetStick(num++, (sp + (p * (t * 126))) * vel);
        SetStick(num++, (sp + (p * (t * 127))) * vel);
        //SetStick(num++, (sp + (p * (t * 128))) * vel);
        //SetStick(num++, (sp + (p * (t * 129))) * vel);
        //SetStick(num++, (sp + (p * (t * 130))) * vel);
        //SetStick(num++, (sp + (p * (t * 131))) * vel);
        //SetStick(num++, (sp + (p * (t * 132))) * vel);
        SetStick(num++, (sp + (p * (t * 133))) * vel);
        //SetStick(num++, (sp + (p * (t * 134))) * vel);
        SetStick(num++, (sp + (p * (t * 135))) * vel);
        //SetStick(num++, (sp + (p * (t * 136))) * vel);
        SetStick(num++, (sp + (p * (t * 137))) * vel);
        //SetStick(num++, (sp + (p * (t * 138))) * vel);
        SetStick(num++, (sp + (p * (t * 139))) * vel);
        //SetStick(num++, (sp + (p * (t * 140))) * vel);
        SetStick(num++, (sp + (p * (t * 141))) * vel);
        //SetStick(num++, (sp + (p * (t * 142))) * vel);
        SetStick(num++, (sp + (p * (t * 143))) * vel);
        //SetStick(num++, (sp + (p * (t * 144))) * vel);
        SetStick(num++, (sp + (p * (t * 145))) * vel);
        //SetStick(num++, (sp + (p * (t * 146))) * vel);
        SetStick(num++, (sp + (p * (t * 147))) * vel);
        SetStick(num++, (sp + (p * (t * 148))) * vel);
        SetStick(num++, (sp + (p * (t * 149))) * vel);
        SetStick(num++, (sp + (p * (t * 150))) * vel);
        SetStick(num++, (sp + (p * (t * 151))) * vel);
        //SetStick(num++, (sp + (p * (t * 152))) * vel);
        SetStick(num++, (sp + (p * (t * 153))) * vel);
        //SetStick(num++, (sp + (p * (t * 154))) * vel);
        SetStick(num++, (sp + (p * (t * 155))) * vel);
        //SetStick(num++, (sp + (p * (t * 156))) * vel);
        SetStick(num++, (sp + (p * (t * 157))) * vel);
        //SetStick(num++, (sp + (p * (t * 158))) * vel);
        //SetStick(num++, (sp + (p * (t * 159))) * vel);
        SetStick(num++, (sp + (p * (t * 160))) * vel);
        //SetStick(num++, (sp + (p * (t * 161))) * vel);
        //SetStick(num++, (sp + (p * (t * 162))) * vel);
        //SetStick(num++, (sp + (p * (t * 163))) * vel);
        //SetStick(num++, (sp + (p * (t * 164))) * vel);
        SetStick(num++, (sp + (p * (t * 165))) * vel);
        //SetStick(num++, (sp + (p * (t * 166))) * vel);
        SetStick(num++, (sp + (p * (t * 167))) * vel);
        //SetStick(num++, (sp + (p * (t * 168))) * vel);
        SetStick(num++, (sp + (p * (t * 169))) * vel);
        //SetStick(num++, (sp + (p * (t * 170))) * vel);
        SetStick(num++, (sp + (p * (t * 171))) * vel);
        SetStick(num++, (sp + (p * (t * 172))) * vel);
        //SetStick(num++, (sp + (p * (t * 173))) * vel);
        //SetStick(num++, (sp + (p * (t * 174))) * vel);
        //SetStick(num++, (sp + (p * (t * 175))) * vel);
        //SetStick(num++, (sp + (p * (t * 176))) * vel);
        //SetStick(num++, (sp + (p * (t * 177))) * vel);
        //SetStick(num++, (sp + (p * (t * 178))) * vel);
        SetStick(num++, (sp + (p * (t * 179))) * vel);
        //SetStick(num++, (sp + (p * (t * 180))) * vel);
        //SetStick(num++, (sp + (p * (t * 181))) * vel);        // òAë≈
        //SetStick(num++, (sp + (p * (t * 182))) * vel);
        //SetStick(num++, (sp + (p * (t * 183))) * vel);
        //SetStick(num++, (sp + (p * (t * 184))) * vel);
        //SetStick(num++, (sp + (p * (t * 185))) * vel);
        //SetStick(num++, (sp + (p * (t * 186))) * vel);
        //SetStick(num++, (sp + (p * (t * 187))) * vel);
        //SetStick(num++, (sp + (p * (t * 188))) * vel);
        //SetStick(num++, (sp + (p * (t * 189))) * vel);
        //SetStick(num++, (sp + (p * (t * 190))) * vel);
        //SetStick(num++, (sp + (p * (t * 191))) * vel);
        //SetStick(num++, (sp + (p * (t * 192))) * vel);
        SetStick(num++, (sp + (p * (t * 193))) * vel);
        SetStick(num++, (sp + (p * (t * 194))) * vel);
        SetStick(num++, (sp + (p * (t * 195))) * vel);
        SetStick(num++, (sp + (p * (t * 196))) * vel);
        SetStick(num++, (sp + (p * (t * 197))) * vel);
        //SetStick(num++, (sp + (p * (t * 198))) * vel);
        SetStick(num++, (sp + (p * (t * 199))) * vel);
        //SetStick(num++, (sp + (p * (t * 200))) * vel);
        SetStick(num++, (sp + (p * (t * 201))) * vel);
        SetStick(num++, (sp + (p * (t * 202))) * vel);
        SetStick(num++, (sp + (p * (t * 203))) * vel);
        SetStick(num++, (sp + (p * (t * 204))) * vel);
        //SetStick(num++, (sp + (p * (t * 205))) * vel);        // òAë≈
        //SetStick(num++, (sp + (p * (t * 206))) * vel);
        SetStick(num++, (sp + (p * (t * 207))) * vel);
        //SetStick(num++, (sp + (p * (t * 208))) * vel);
        //      SetStick(num++, (sp + (p * (t * 209))) * vel);
        SetStick(num++, (sp + (p * (t * 210))) * vel);
        //SetStick(num++, (sp + (p * (t * 211))) * vel);
        //SetStick(num++, (sp + (p * (t * 212))) * vel);
        //SetStick(num++, (sp + (p * (t * 213))) * vel);
        SetStick(num++, (sp + (p * (t * 214))) * vel);
        SetStick(num++, (sp + (p * (t * 215))) * vel);
        //SetStick(num++, (sp + (p * (t * 216))) * vel);
        SetStick(num++, (sp + (p * (t * 217))) * vel);
        //SetStick(num++, (sp + (p * (t * 218))) * vel);
        SetStick(num++, (sp + (p * (t * 219))) * vel);
        //SetStick(num++, (sp + (p * (t * 220))) * vel);
        SetStick(num++, (sp + (p * (t * 221))) * vel);
        SetStick(num++, (sp + (p * (t * 222))) * vel);
        //SetStick(num++, (sp + (p * (t * 223))) * vel);
        //SetStick(num++, (sp + (p * (t * 224))) * vel);
        //SetStick(num++, (sp + (p * (t * 225))) * vel);
        //SetStick(num++, (sp + (p * (t * 226))) * vel);
        SetStick(num++, (sp + (p * (t * 227))) * vel);
        //SetStick(num++, (sp + (p * (t * 228))) * vel);
        SetStick(num++, (sp + (p * (t * 229))) * vel);
        //SetStick(num++, (sp + (p * (t * 230))) * vel);
        SetStick(num++, (sp + (p * (t * 231))) * vel);
        //SetStick(num++, (sp + (p * (t * 232))) * vel);
        SetStick(num++, (sp + (p * (t * 233))) * vel);
        //SetStick(num++, (sp + (p * (t * 234))) * vel);
        //SetStick(num++, (sp + (p * (t * 235))) * vel);
        SetStick(num++, (sp + (p * (t * 236))) * vel);
        //SetStick(num++, (sp + (p * (t * 237))) * vel);
        //SetStick(num++, (sp + (p * (t * 238))) * vel);
        //SetStick(num++, (sp + (p * (t * 239))) * vel);
        //SetStick(num++, (sp + (p * (t * 240))) * vel);
        //SetStick(num++, (sp + (p * (t * 241))) * vel);
        //SetStick(num++, (sp + (p * (t * 242))) * vel);
        //SetStick(num++, (sp + (p * (t * 243))) * vel);
        //SetStick(num++, (sp + (p * (t * 244))) * vel);
        SetStick(num++, (sp + (p * (t * 245))) * vel);
        //SetStick(num++, (sp + (p * (t * 246))) * vel);
        //SetStick(num++, (sp + (p * (t * 247))) * vel);
        SetStick(num++, (sp + (p * (t * 248))) * vel);
        //SetStick(num++, (sp + (p * (t * 249))) * vel);
        //SetStick(num++, (sp + (p * (t * 250))) * vel);
        SetStick(num++, (sp + (p * (t * 251))) * vel);
        //SetStick(num++, (sp + (p * (t * 252))) * vel);
        SetStick(num++, (sp + (p * (t * 253))) * vel);
        //SetStick(num++, (sp + (p * (t * 254))) * vel);
        SetStick(num++, (sp + (p * (t * 255))) * vel);
        //SetStick(num++, (sp + (p * (t * 256))) * vel);
        SetStick(num++, (sp + (p * (t * 257))) * vel);
        SetStick(num++, (sp + (p * (t * 258))) * vel);
        SetStick(num++, (sp + (p * (t * 259))) * vel);
        SetStick(num++, (sp + (p * (t * 260))) * vel);
        SetStick(num++, (sp + (p * (t * 261))) * vel);
        SetStick(num++, (sp + (p * (t * 262))) * vel);
        SetStick(num++, (sp + (p * (t * 263))) * vel);
        //SetStick(num++, (sp + (p * (t * 264))) * vel);
        SetStick(num++, (sp + (p * (t * 265))) * vel);
        //SetStick(num++, (sp + (p * (t * 266))) * vel);
        SetStick(num++, (sp + (p * (t * 267))) * vel);
        //SetStick(num++, (sp + (p * (t * 268))) * vel);
        SetStick(num++, (sp + (p * (t * 269))) * vel);
        SetStick(num++, (sp + (p * (t * 270))) * vel);

        // --------------------------------------

        Max = num;
    }

    public override void SetEnemyData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        float bpm = 120.0f;
        float sp = 0.0f;
        float p = 30 / bpm;
        float t = 1.0f;

        // EnemyÉRÉsÉyÉ]Å[Éì --------------------

		SetEnemy(num++, (sp + (p * (t * 2))) * vel - error, 0 * updown, enemyTypeA);
		SetEnemy(num++, (sp + (p * (t * 3))) * vel - error, 0 * updown, enemyTypeA);
		SetEnemy(num++, (sp + (p * (t * 4))) * vel - error, 0 * updown, enemyTypeA);
		SetEnemy(num++, (sp + (p * (t * 5))) * vel - error, 0 * updown, enemyTypeA);
		SetEnemy(num++, (sp + (p * (t * 6))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 6))) * vel - error, -1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 9))) * vel - error, 0 * updown, enemyTypeA);



        //SetEnemy(num++, (sp + (p * (t * 13))) * vel - error, 0 * updown, enemyTypeA);

		SetEnemy(num++, (sp + (p * (t * 14))) * vel - error, 1 * updown, enemyTypeA);
		SetEnemy(num++, (sp + (p * (t * 15))) * vel - error, 1 * updown, enemyTypeA);
		SetEnemy(num++, (sp + (p * (t * 16))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 17))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 18))) * vel - error, 1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 20))) * vel - error, -1 * updown, enemyTypeA);

        // 

        //SetEnemy(num++, (sp + (p * (t * 24))) * vel - error, -1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 26))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 27))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 28))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 29))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 30))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 32))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 34))) * vel - error, -1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 36))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 37))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 38))) * vel - error, -1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 41))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 42))) * vel - error, 0 * updown, enemyTypeA);


        //SetEnemy(num++, (sp + (p * (t * 45))) * vel - error, 1 * updown, enemyTypeA);


        SetEnemy(num++, (sp + (p * (t * 48))) * vel - error, 1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 50))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 51))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 52))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 53))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 54))) * vel - error, 1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 56))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 58))) * vel - error, -1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 60))) * vel - error, 0 * updown, enemyTypeA);


        SetEnemy(num++, (sp + (p * (t * 63))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 64))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 65))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 66))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 68))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 70))) * vel - error, -1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 72))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 74))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 75))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 76))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 77))) * vel - error, -1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 78))) * vel - error, -1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 80))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 82))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 84))) * vel - error, 0 * updown, enemyTypeA);



        SetEnemy(num++, (sp + (p * (t * 88))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 90))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 93))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 95))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 96))) * vel - error, 0 * updown, enemyTypeA);


        SetEnemy(num++, (sp + (p * (t * 99))) * vel - error, -1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 102))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 104))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 105))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 106))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 108))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 110))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 111))) * vel - error, 1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 114))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 116))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 117))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 118))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 120))) * vel - error, 0 * updown, enemyTypeA);


        SetEnemy(num++, (sp + (p * (t * 123))) * vel - error, -1 * updown, enemyTypeA);


        SetEnemy(num++, (sp + (p * (t * 126))) * vel - error, -1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 129))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 131))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 132))) * vel - error, -1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 134))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 136))) * vel - error, -1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 138))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 140))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 142))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 144))) * vel - error, 1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 146))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 147))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 148))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 149))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 150))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 152))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 154))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 156))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 159))) * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, (sp + (p * (t * 159))) * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, (sp + (p * (t * 161))) * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, (sp + (p * (t * 162))) * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, (sp + (p * (t * 163))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 164))) * vel - error, -1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 166))) * vel - error, -1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 168))) * vel - error, -1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 170))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 171))) * vel - error, -1 * updown, enemyTypeA);
        //SetEnemy(num++, (sp + (p * (t * 173))) * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, (sp + (p * (t * 174))) * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, (sp + (p * (t * 175))) * vel - error, 0 * updown, enemyTypeA);



        SetEnemy(num++, (sp + (p * (t * 178))) * vel - error, -1 * updown, enemyTypeA);













        SetEnemy(num++, (sp + (p * (t * 192))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 193))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 194))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 195))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 196))) * vel - error, 1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 198))) * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, (sp + (p * (t * 200))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 200))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 201))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 202))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 203))) * vel - error, 0 * updown, enemyTypeA);


        //SetEnemy(num++, (sp + (p * (t * 206))) * vel - error, -1 * updown, enemyTypeA);


        //SetEnemy(num++, (sp + (p * (t * 209))) * vel - error, 0 * updown, enemyTypeA);


        //SetEnemy(num++, (sp + (p * (t * 213))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 213))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 214))) * vel - error, 1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 216))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 218))) * vel - error, -1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 220))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 221))) * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, (sp + (p * (t * 223))) * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, (sp + (p * (t * 224))) * vel - error, 0 * updown, enemyTypeA);


        SetEnemy(num++, (sp + (p * (t * 226))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 228))) * vel - error, -1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 230))) * vel - error, -1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 232))) * vel - error, 1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 235))) * vel - error, 0 * updown, enemyTypeA);
        //SetEnemy(num++, (sp + (p * (t * 237))) * vel - error, 0 * updown, enemyTypeA);



        SetEnemy(num++, (sp + (p * (t * 244))) * vel - error, 0 * updown, enemyTypeA);


        //SetEnemy(num++, (sp + (p * (t * 247))) * vel - error, -1 * updown, enemyTypeA);


        SetEnemy(num++, (sp + (p * (t * 250))) * vel - error, 1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 252))) * vel - error, 1 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 254))) * vel - error, -1 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 256))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 257))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 258))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 259))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 260))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 261))) * vel - error, 0 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 262))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 264))) * vel - error, 0 * updown, enemyTypeA);

        //SetEnemy(num++, (sp + (p * (t * 266))) * vel - error, 0 * updown, enemyTypeA);

        SetEnemy(num++, (sp + (p * (t * 268))) * vel - error, 1 * updown, enemyTypeA);
        SetEnemy(num++, (sp + (p * (t * 269))) * vel - error, 1 * updown, enemyTypeA);

        // --------------------------------------
    }

    public override void SetObstacleData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        float error = -5.0f;

        float bpm = 120.0f;
        float sp = 0.0f;
        float p = 30 / bpm;
        float t = 1.0f;

        // ObstacleÉRÉsÉyÉ]Å[Éì -----------------

        //SetObstacle(num++, (sp + (p * (t * 1))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 3))) * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, (sp + (p * (t * 3))) * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, (sp + (p * (t * 4))) * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, (sp + (p * (t * 5))) * vel - error, 0 * updown, obstacleTypeA);
        //SetObstacle(num++, (sp + (p * (t * 6))) * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, (sp + (p * (t * 7))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 9))) * vel - error, 0 * updown, obstacleTypeG);



        //SetObstacle(num++, (sp + (p * (t * 13))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 15))) * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, (sp + (p * (t * 16))) * vel - error, -1 * updown, obstacleTypeA);
        //SetObstacle(num++, (sp + (p * (t * 17))) * vel - error, 1 * updown, obstacleTypeA);
        //SetObstacle(num++, (sp + (p * (t * 18))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 19))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 21))) * vel - error, 0 * updown, obstacleTypeG);



        //SetObstacle(num++, (sp + (p * (t * 25))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 27))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 28))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 29))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 30))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 31))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 33))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 35))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 37))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 38))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 39))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 41))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 43))) * vel - error, 0 * updown, obstacleTypeG);


        //SetObstacle(num++, (sp + (p * (t * 46))) * vel - error, 0 * updown, obstacleTypeG);


        //SetObstacle(num++, (sp + (p * (t * 49))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 51))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 52))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 53))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 54))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 55))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 57))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 59))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 61))) * vel - error, 0 * updown, obstacleTypeG);


        //SetObstacle(num++, (sp + (p * (t * 64))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 65))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 66))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 67))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 69))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 71))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 73))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 75))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 76))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 77))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 78))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 79))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 81))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 83))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 85))) * vel - error, 0 * updown, obstacleTypeG);



        //SetObstacle(num++, (sp + (p * (t * 89))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 91))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 93))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 95))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 97))) * vel - error, 0 * updown, obstacleTypeG);


        //SetObstacle(num++, (sp + (p * (t * 100))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 103))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 105))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 106))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 107))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 109))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 111))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 112))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 115))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 117))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 118))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 119))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 121))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 124))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 127))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 129))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 131))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 133))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 135))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 137))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 139))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 141))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 143))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 145))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 147))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 148))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 149))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 150))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 151))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 153))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 155))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 157))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 159))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 160))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 161))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 162))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 163))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 165))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 167))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 169))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 171))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 172))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 173))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 174))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 175))) * vel - error, 0 * updown, obstacleTypeG);



        //SetObstacle(num++, (sp + (p * (t * 179))) * vel - error, 0 * updown, obstacleTypeG);













        //SetObstacle(num++, (sp + (p * (t * 193))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 194))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 195))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 196))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 197))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 199))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 200))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 201))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 202))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 203))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 204))) * vel - error, 0 * updown, obstacleTypeG);


        //SetObstacle(num++, (sp + (p * (t * 207))) * vel - error, 0 * updown, obstacleTypeG);


        //SetObstacle(num++, (sp + (p * (t * 210))) * vel - error, 0 * updown, obstacleTypeG);


        //SetObstacle(num++, (sp + (p * (t * 213))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 214))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 215))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 217))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 219))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 221))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 222))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 223))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 224))) * vel - error, 0 * updown, obstacleTypeG);


        //SetObstacle(num++, (sp + (p * (t * 227))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 229))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 231))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 233))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 236))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 237))) * vel - error, 0 * updown, obstacleTypeG);







        //SetObstacle(num++, (sp + (p * (t * 245))) * vel - error, 0 * updown, obstacleTypeG);


        //SetObstacle(num++, (sp + (p * (t * 248))) * vel - error, 0 * updown, obstacleTypeG);


        //SetObstacle(num++, (sp + (p * (t * 251))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 253))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 255))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 257))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 258))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 259))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 260))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 261))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 262))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 263))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 265))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 267))) * vel - error, 0 * updown, obstacleTypeG);

        //SetObstacle(num++, (sp + (p * (t * 269))) * vel - error, 0 * updown, obstacleTypeG);
        //SetObstacle(num++, (sp + (p * (t * 270))) * vel - error, 0 * updown, obstacleTypeG);

        // --------------------------------------
    }

    public override float SetMoveLimit()
    {
        // return ((stickPosDataArray[Max - 1]) + 6.0f);
        return ((stickPosDataArray[Max - 1]) + 48.0f);
    }

    public override int GetLastStick()
    {
        return (Max - 1);
    }
}