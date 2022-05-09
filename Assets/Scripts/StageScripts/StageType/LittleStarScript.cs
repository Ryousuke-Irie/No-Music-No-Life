using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleStarScript : StageScript
{
    public GameObject enemyTypeA;
    public GameObject obstacleTypeA;

    public override void SetStickData()
    {
        // åvéZéÆ
        // ècñ_ÇÃä‘äu = 60(s) / x(BPM) * PlayerÇÃë¨ìx     PlayerÇÃë¨ìxÇ™10Ç∆Ç∑ÇÈÅB100BPMÇçèÇﬁèÍçáècñ_ÇÃä‘äuÇÕ6.0ñà (60s/100BPM * 10)
        // å¬êî = a(s) / 60(s) * x(BPM)                   ã»Ç™12ïbÇ≈100BPMÇÃèÍçáÇÕ20å¬ècñ_Ç™ïKóv (0.2 * 100BPM)

        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;

        for (int i = 0; i < 18; i++)
        {
            SetStick(i, (i + 1) * 0.554f * vel - 2.0f);
        }

        for (int i = 0; i < 16; i++)
        {
            SetStick(i + 18, (i + 1) * 0.46f * vel + (18) * 0.554f * vel - 2.0f);
        }

        for (int i = 0; i < 15; i++)
        {
            SetStick(i + 34, (i + 1) * 0.494f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel);
        }

        for (int i = 0; i < 17; i++)
        {
            SetStick(i + 49, (i + 1) * 0.4587f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel);
        }

        for (int i = 0; i < 48; i++)
        {
            SetStick(i + 66, (i + 1) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel);
        }

        for (int i = 0; i < 31; i++)
        {
            SetStick(i + 114, (i + 1) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel);
        }

        for (int i = 0; i < 17; i++)
        {
            SetStick(i + 145, (i + 1) * 0.5842f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel);
        }

        for (int i = 0; i < 24; i++)
        {
            SetStick(i + 162, (i + 1) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel);
        }

        for (int i = 0; i < 32; i++)
        {
            SetStick(i + 186, (i + 1) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel);
        }
    }

    public override void SetEnemyData()
    {
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        int num = 0;
        // 18
        SetEnemy(num++, (3) * 0.554f * vel - 2.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, (6) * 0.554f * vel - 2.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, (7) * 0.554f * vel - 2.0f - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, (10) * 0.554f * vel - 2.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, (12) * 0.554f * vel - 2.0f - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, (14) * 0.554f * vel - 2.0f - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, (17) * 0.554f * vel - 2.0f - 0.7f, 0.0f, enemyTypeA);

        // 16
        SetEnemy(num++, (3) * 0.46f * vel + (18) * 0.554f * vel - 2.0f - 0.1f, 4.0f, enemyTypeA);
        SetEnemy(num++, (8) * 0.46f * vel + (18) * 0.554f * vel - 2.0f - 0.1f, 0.0f, enemyTypeA);
        SetEnemy(num++, (12) * 0.46f * vel + (18) * 0.554f * vel - 2.0f - 0.1f, -4.0f, enemyTypeA);
        SetEnemy(num++, (13) * 0.46f * vel + (18) * 0.554f * vel - 2.0f - 0.1f, -4.0f, enemyTypeA);

        // 15
        SetEnemy(num++, (5) * 0.494f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel - 0.2f, 0.0f, enemyTypeA);
        SetEnemy(num++, (8) * 0.494f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel - 0.2f, 0.0f, enemyTypeA);
        SetEnemy(num++, (10) * 0.494f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel - 0.2f, -4.0f, enemyTypeA);
        SetEnemy(num++, (13) * 0.494f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel - 0.2f, 4.0f, enemyTypeA);

        // 17
        SetEnemy(num++, (2) * 0.4587f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel - 0.1f, 4.0f, enemyTypeA);
        SetEnemy(num++, (4) * 0.4587f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel - 0.1f, 0.0f, enemyTypeA);
        SetEnemy(num++, (6) * 0.4587f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel - 0.1f, -4.0f, enemyTypeA);
        SetEnemy(num++, (8) * 0.4587f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel - 0.1f, 0.0f, enemyTypeA);
        SetEnemy(num++, (13) * 0.4587f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel - 0.1f, -4.0f, enemyTypeA);
        SetEnemy(num++, (16) * 0.4587f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel - 0.1f, 4.0f, enemyTypeA);

        // 48
        SetEnemy(num++, (3) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, 0.0f, enemyTypeA);
        SetEnemy(num++, (6) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, 4.0f, enemyTypeA);
        SetEnemy(num++, (9) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, 0.0f, enemyTypeA);
        SetEnemy(num++, (14) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, -4.0f, enemyTypeA);
        SetEnemy(num++, (15) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, -4.0f, enemyTypeA);
        SetEnemy(num++, (19) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, 0.0f, enemyTypeA);
        SetEnemy(num++, (23) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, 4.0f, enemyTypeA);
        SetEnemy(num++, (27) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, 0.0f, enemyTypeA);
        SetEnemy(num++, (31) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, -4.0f, enemyTypeA);
        SetEnemy(num++, (34) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, 4.0f, enemyTypeA);
        SetEnemy(num++, (36) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, 4.0f, enemyTypeA);
        SetEnemy(num++, (39) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, -4.0f, enemyTypeA);
        SetEnemy(num++, (40) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, -4.0f, enemyTypeA);
        SetEnemy(num++, (43) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, 0.0f, enemyTypeA);
        SetEnemy(num++, (45) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel - 0.5f, 0.0f, enemyTypeA);

        // 31
        SetEnemy(num++, (1) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel - 0.1f, 4.0f, enemyTypeA);
        SetEnemy(num++, (4) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel - 0.1f, 0.0f, enemyTypeA);
        SetEnemy(num++, (6) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel - 0.1f, 4.0f, enemyTypeA);
        SetEnemy(num++, (9) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel - 0.1f, -4.0f, enemyTypeA);
        SetEnemy(num++, (12) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel - 0.1f, 4.0f, enemyTypeA);
        SetEnemy(num++, (16) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel - 0.1f, -4.0f, enemyTypeA);
        SetEnemy(num++, (19) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel - 0.1f, 4.0f, enemyTypeA);
        SetEnemy(num++, (21) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel - 0.1f, 0.0f, enemyTypeA);
        SetEnemy(num++, (25) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel - 0.1f, 0.0f, enemyTypeA);
        SetEnemy(num++, (28) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel - 0.1f, -4.0f, enemyTypeA);
        SetEnemy(num++, (30) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel - 0.1f, -4.0f, enemyTypeA);

        // 17
        SetEnemy(num++, (2) * 0.5842f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, (5) * 0.5842f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel - 0.7f, 4.0f, enemyTypeA);
        SetEnemy(num++, (7) * 0.5842f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, (10) * 0.5842f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, (11) * 0.5842f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel - 0.7f, -4.0f, enemyTypeA);
        SetEnemy(num++, (13) * 0.5842f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel - 0.7f, 0.0f, enemyTypeA);
        SetEnemy(num++, (15) * 0.5842f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel - 0.7f, -4.0f, enemyTypeA);

        // 24
        SetEnemy(num++, (2) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel - 1.2f, -4.0f, enemyTypeA);
        SetEnemy(num++, (5) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel - 1.2f, 4.0f, enemyTypeA);
        SetEnemy(num++, (7) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel - 1.2f, 0.0f, enemyTypeA);
        SetEnemy(num++, (10) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel - 1.2f, 4.0f, enemyTypeA);
        SetEnemy(num++, (13) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel - 1.2f, -4.0f, enemyTypeA);
        SetEnemy(num++, (15) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel - 1.2f, 0.0f, enemyTypeA);
        SetEnemy(num++, (18) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel - 1.2f, 4.0f, enemyTypeA);
        SetEnemy(num++, (21) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel - 1.2f, 4.0f, enemyTypeA);
        SetEnemy(num++, (23) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel - 1.2f, 0.0f, enemyTypeA);

        // 32
        SetEnemy(num++, (3) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel - 0.9f, -4.0f, enemyTypeA);
        SetEnemy(num++, (7) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel - 0.9f, 0.0f, enemyTypeA);
        SetEnemy(num++, (10) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel - 0.9f, 4.0f, enemyTypeA);
        SetEnemy(num++, (15) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel - 0.9f, 4.0f, enemyTypeA);
        SetEnemy(num++, (19) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel - 0.9f, 0.0f, enemyTypeA);
        SetEnemy(num++, (23) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel - 0.9f, -4.0f, enemyTypeA);
        SetEnemy(num++, (26) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel - 0.9f, -4.0f, enemyTypeA);
        SetEnemy(num++, (29) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel - 0.9f, 0.0f, enemyTypeA);

    }

    public override void SetObstacleData()
    {
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;
        int num = 0;
        // 18
        SetObstacle(num++, (3) * 0.554f * vel - 2.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, (4) * 0.554f * vel - 2.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, (6) * 0.554f * vel - 2.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, (8) * 0.554f * vel - 2.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, (11) * 0.554f * vel - 2.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, (15) * 0.554f * vel - 2.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, (17) * 0.554f * vel - 2.0f, 4.0f, obstacleTypeA);

        // 16
        SetObstacle(num++, (1) * 0.46f * vel + (18) * 0.554f * vel - 2.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, (5) * 0.46f * vel + (18) * 0.554f * vel - 2.0f, 0.0f, obstacleTypeA);
        SetObstacle(num++, (8) * 0.46f * vel + (18) * 0.554f * vel - 2.0f, -4.0f, obstacleTypeA);
        SetObstacle(num++, (11) * 0.46f * vel + (18) * 0.554f * vel - 2.0f, 4.0f, obstacleTypeA);
        SetObstacle(num++, (15) * 0.46f * vel + (18) * 0.554f * vel - 2.0f, 0.0f, obstacleTypeA);

        // 15
        SetObstacle(num++, (2) * 0.494f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel, 4.0f, obstacleTypeA);
        SetObstacle(num++, (8) * 0.494f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel, 4.0f, obstacleTypeA);
        SetObstacle(num++, (15) * 0.494f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel, -4.0f, obstacleTypeA);
        SetObstacle(num++, (15) * 0.494f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel, 0.0f, obstacleTypeA);

        // 17
        SetObstacle(num++, (9) * 0.4587f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel, 0.0f, obstacleTypeA);

        // 48
        SetObstacle(num++, (6) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel, -4.0f, obstacleTypeA);
        SetObstacle(num++, (9) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel, 4.0f, obstacleTypeA);
        SetObstacle(num++, (12) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel, 4.0f, obstacleTypeA);
        SetObstacle(num++, (14) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel, 0.0f, obstacleTypeA);
        SetObstacle(num++, (25) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel, -4.0f, obstacleTypeA);
        SetObstacle(num++, (29) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel, 4.0f, obstacleTypeA);
        SetObstacle(num++, (35) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel, 0.0f, obstacleTypeA);
        SetObstacle(num++, (40) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel, 0.0f, obstacleTypeA);
        SetObstacle(num++, (43) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel, 4.0f, obstacleTypeA);
        SetObstacle(num++, (47) * 0.5217f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel, 0.0f, obstacleTypeA);

        // 31
        SetObstacle(num++, (1) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel, -4.0f, obstacleTypeA);
        SetObstacle(num++, (10) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel, 0.0f, obstacleTypeA);
        SetObstacle(num++, (20) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel, 4.0f, obstacleTypeA);
        SetObstacle(num++, (25) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel, 4.0f, obstacleTypeA);
        SetObstacle(num++, (30) * 0.46875f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel, 0.0f, obstacleTypeA);

        // 17
        SetObstacle(num++, (2) * 0.5842f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel, -4.0f, obstacleTypeA);
        SetObstacle(num++, (8) * 0.5842f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel, 0.0f, obstacleTypeA);
        SetObstacle(num++, (15) * 0.5842f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel, 4.0f, obstacleTypeA);

        // 24
        SetObstacle(num++, (2) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel, 4.0f, obstacleTypeA);
        SetObstacle(num++, (7) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel, -4.0f, obstacleTypeA);
        SetObstacle(num++, (11) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel, 4.0f, obstacleTypeA);
        SetObstacle(num++, (14) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel, -4.0f, obstacleTypeA);
        SetObstacle(num++, (21) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel, -4.0f, obstacleTypeA);
        SetObstacle(num++, (24) * 0.7722f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel, 0.0f, obstacleTypeA);

        // 32
        SetObstacle(num++, (3) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel, 0.0f, obstacleTypeA);
        SetObstacle(num++, (9) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel, -4.0f, obstacleTypeA);
        SetObstacle(num++, (16) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel, 0.0f, obstacleTypeA);
        SetObstacle(num++, (21) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel, 4.0f, obstacleTypeA);
        SetObstacle(num++, (30) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel, 0.0f, obstacleTypeA);
    }

    public override float SetMoveLimit()
    {
        float vel = refObjp.GetComponent<PlayerScript>().BesideMoveAmount;

        float limit = 6.0f + (32) * 0.681f * vel + (18) * 0.554f * vel - 2.0f + (16) * 0.46f * vel + (15) * 0.494f * vel + (17) * 0.4587f * vel + (48) * 0.5217f * vel + (31) * 0.46875f * vel + (17) * 0.5842f * vel + (24) * 0.7722f * vel;

        return (limit);
    }

    public override int GetLastStick()
    {
        return (217);
    }
}
