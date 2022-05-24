using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript_04_No06 : StageScript
{
    public GameObject enemyTypeA;
    public GameObject enemyTypeB;
    public GameObject obstacleTypeA;

    private int Max = 0;

    public override void SetStickData()
    {
        int num = 0;
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;

        float bpm = 115.0f;
        float sp = 0.10f;
        float p = 60 / bpm;
        float t = 1.0f;
        // Stickコピペゾーン --------------------

        // SetStick(num++, (sp + (p * (t * 0))) * vel);
        SetStick(num++, (sp + (p * (t * 1))) * vel);
        // SetStick(num++, (sp + (p * (t * 2))) * vel);
        // SetStick(num++, (sp + (p * (t * 3))) * vel);
        SetStick(num++, (sp + (p * (t * 4))) * vel);
        // SetStick(num++, (sp + (p * (t * 5))) * vel);
        // SetStick(num++, (sp + (p * (t * 6))) * vel);
        SetStick(num++, (sp + (p * (t * 7))) * vel);
        SetStick(num++, (sp + (p * (t * 8))) * vel);
        // SetStick(num++, (sp + (p * (t * 9))) * vel);
        //  SetStick(num++, (sp + (p * (t * 10))) * vel);
        SetStick(num++, (sp + (p * (t * 11))) * vel);
        // SetStick(num++, (sp + (p * (t * 12))) * vel);
        SetStick(num++, (sp + (p * (t * 13))) * vel);
        // SetStick(num++, (sp + (p * (t * 14))) * vel);
        SetStick(num++, (sp + (p * (t * 15))) * vel);
        // SetStick(num++, (sp + (p * (t * 16))) * vel);
        SetStick(num++, (sp + (p * (t * 17))) * vel);
        //SetStick(num++, (sp + (p * (t * 18))) * vel);
        SetStick(num++, (sp + (p * (t * 19))) * vel);
        //SetStick(num++, (sp + (p * (t * 20))) * vel);
        SetStick(num++, (sp + (p * (t * 21))) * vel);
        // SetStick(num++, (sp + (p * (t * 22))) * vel);
        SetStick(num++, (sp + (p * (t * 23))) * vel);
        //  SetStick(num++, (sp + (p * (t * 24))) * vel);
        SetStick(num++, (sp + (p * (t * 25))) * vel);
        //  SetStick(num++, (sp + (p * (t * 26))) * vel);
        SetStick(num++, (sp + (p * (t * 27))) * vel);
        // SetStick(num++, (sp + (p * (t * 28)))* vel);
        //  SetStick(num++, (sp + (p * (t * 29)))* vel);
        SetStick(num++, (sp + (p * (t * 30))) * vel);
        //  SetStick(num++, (sp + (p * (t * 31))) * vel);
        SetStick(num++, (sp + (p * (t * 32))) * vel);
        SetStick(num++, (sp + (p * (t * 33))) * vel);
        SetStick(num++, (sp + (p * (t * 34))) * vel);
        //SetStick(num++, (sp + (p * (t * 35)))* vel);
        SetStick(num++, (sp + (p * (t * 36))) * vel);
        SetStick(num++, (sp + (p * (t * 37))) * vel);
        SetStick(num++, (sp + (p * (t * 38))) * vel);
        // SetStick(num++, (sp + (p * (t * 39))) * vel);
        SetStick(num++, (sp + (p * (t * 40))) * vel);
        // SetStick(num++, (sp + (p * (t * 41))) * vel);
        SetStick(num++, (sp + (p * (t * 42))) * vel);
        //  SetStick(num++, (sp + (p * (t * 43))) * vel);
        SetStick(num++, (sp + (p * (t * 44))) * vel);
        //  SetStick(num++, (sp + (p * (t * 45))) * vel);
        SetStick(num++, (sp + (p * (t * 46))) * vel);
        //  SetStick(num++, (sp + (p * (t * 47))) * vel);
        SetStick(num++, (sp + (p * (t * 48))) * vel);
        // SetStick(num++, (sp + (p * (t * 49))) * vel);
        SetStick(num++, (sp + (p * (t * 50))) * vel);
        // SetStick(num++, (sp + (p * (t * 51))) * vel);
        SetStick(num++, (sp + (p * (t * 52))) * vel);
        //  SetStick(num++, (sp + (p * (t * 53))) * vel);
        SetStick(num++, (sp + (p * (t * 54))) * vel);
        // SetStick(num++, (sp + (p * (t * 55))) * vel);
        // SetStick(num++, (sp + (p * (t * 56))) * vel);
        // SetStick(num++, (sp + (p * (t * 57))) * vel);
        SetStick(num++, (sp + (p * (t * 58))) * vel);
        // SetStick(num++, (sp + (p * (t * 59))) * vel);
        SetStick(num++, (sp + (p * (t * 60))) * vel);
        //  SetStick(num++, (sp + (p * (t * 61))) * vel);
        SetStick(num++, (sp + (p * (t * 62))) * vel);
        // SetStick(num++, (sp + (p * (t * 63))) * vel);
        SetStick(num++, (sp + (p * (t * 64))) * vel);
        // SetStick(num++, (sp + (p * (t * 65))) * vel);
        SetStick(num++, (sp + (p * (t * 66))) * vel);
        // SetStick(num++, (sp + (p * (t * 67))) * vel);
        SetStick(num++, (sp + (p * (t * 68))) * vel);
        // SetStick(num++, (sp + (p * (t * 69))) * vel);
        SetStick(num++, (sp + (p * (t * 70))) * vel);
        // SetStick(num++, (sp + (p * (t * 71))) * vel);
        SetStick(num++, (sp + (p * (t * 72))) * vel);
        //  SetStick(num++, (sp + (p * (t * 73))) * vel);
        // SetStick(num++, (sp + (p * (t * 74)))* vel);
        // SetStick(num++, (sp + (p * (t * 75))) * vel);
        SetStick(num++, (sp + (p * (t * 76))) * vel);
        //SetStick(num++, (sp + (p * (t * 77)))* vel);
        SetStick(num++, (sp + (p * (t * 78))) * vel);
        // SetStick(num++, (sp + (p * (t * 79))) * vel);
        SetStick(num++, (sp + (p * (t * 80))) * vel);
        // SetStick(num++, (sp + (p * (t * 81))) * vel);
        SetStick(num++, (sp + (p * (t * 82))) * vel);
        // SetStick(num++, (sp + (p * (t * 83))) * vel);
        SetStick(num++, (sp + (p * (t * 84))) * vel);
        // SetStick(num++, (sp + (p * (t * 85))) * vel);
        SetStick(num++, (sp + (p * (t * 86))) * vel);
        // SetStick(num++, (sp + (p * (t * 87))) * vel);
        // SetStick(num++, (sp + (p * (t * 88))) * vel);
        // SetStick(num++, (sp + (p * (t * 89))) * vel);
        SetStick(num++, (sp + (p * (t * 90))) * vel);
        SetStick(num++, (sp + (p * (t * 91))) * vel);
        SetStick(num++, (sp + (p * (t * 92))) * vel);
        // SetStick(num++, (sp + (p * (t * 93))) * vel);
        // SetStick(num++, (sp + (p * (t * 94))) * vel);
        SetStick(num++, (sp + (p * (t * 95))) * vel);
        //  SetStick(num++, (sp + (p * (t * 96))) * vel);
        SetStick(num++, (sp + (p * (t * 97))) * vel);
        // SetStick(num++, (sp + (p * (t * 98))) * vel);
        SetStick(num++, (sp + (p * (t * 99))) * vel);
        //  SetStick(num++, (sp + (p * (t * 100))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 101))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 102))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 103))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 104))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 105))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 106))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 107))) * vel);
        //SetStick(num++, (sp + (p * (1.01f * 108))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 109))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 110))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 111))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 112))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 113))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 114))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 115))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 116))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 117))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 118))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 119))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 121))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 122))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 123))) * vel);
        //SetStick(num++, (sp + (p * (1.01f * 124))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 125))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 126))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 127))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 128))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 129))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 130))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 131))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 132))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 133))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 134))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 135))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 136))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 137))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 138))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 139))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 140))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 141))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 142))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 143))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 144))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 145))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 146))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 147))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 148))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 149))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 150))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 151))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 152))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 153))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 154))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 155))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 156))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 157))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 158))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 159))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 160))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 161))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 162))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 163))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 164))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 165))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 166))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 167))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 168))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 169))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 170))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 171))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 172))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 173))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 174))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 175))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 176))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 177))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 178))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 179))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 180))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 181))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 182))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 183))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 184))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 185))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 186))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 187))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 188))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 189))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 190))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 191))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 192))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 193))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 194))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 195))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 196))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 197))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 198))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 199))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 200))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 201))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 202))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 203))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 204))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 205))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 206))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 207))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 208))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 209))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 210))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 211))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 212))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 213))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 214))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 215))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 216))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 217))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 218))) * vel);
        // SetStick(num++, (sp + (p * (1.01f * 219))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 220))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 221))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 222))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 223))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 224))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 225))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 226))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 227))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 228))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 229))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 230))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 231))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 232))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 233))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 234))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 235))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 236))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 237))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 238))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 239))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 240))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 241))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 242))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 243))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 244))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 245))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 246))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 247))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 248))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 249))) * vel);
        //    SetStick(num++, (sp + (p * (1.01f * 250))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 251))) * vel);
        //    SetStick(num++, (sp + (p * (1.01f * 252))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 253))) * vel);
        //    SetStick(num++, (sp + (p * (1.01f * 254))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 255))) * vel);
        //    SetStick(num++, (sp + (p * (1.01f * 256))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 258))) * vel);
        //    SetStick(num++, (sp + (p * (1.01f * 259))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 260))) * vel);
        //    SetStick(num++, (sp + (p * (1.01f * 261))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 262))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 263))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 264))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 265))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 266))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 267))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 268))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 269))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 270))) * vel);
        //    SetStick(num++, (sp + (p * (1.01f * 271))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 272))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 273))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 274))) * vel);
        //    SetStick(num++, (sp + (p * (1.01f * 275))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 276))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 277))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 278))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 279))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 280))) * vel);
        //  SetStick(num++, (sp + (p * (1.01f * 281))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 282))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 283))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 284))) * vel);
        //    SetStick(num++, (sp + (p * (1.01f * 285))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 286))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 287))) * vel);
        //   SetStick(num++, (sp + (p * (1.01f * 288))) * vel);
        SetStick(num++, (sp + (p * (1.01f * 289))) * vel);


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

        // Obstacleコピペゾーン -----------------

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
