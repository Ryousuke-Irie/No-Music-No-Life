using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int barNum_s;

    [Header("SSS")] public GameObject scr1;
    [Header("SS")] public GameObject scr2;
    [Header("S")] public GameObject scr3;
    [Header("A")] public GameObject scr4;
    [Header("B")] public GameObject scr5;
    [Header("C")] public GameObject scr6;
    [Header("D")] public GameObject scr7;

    GameObject[] scrBox;
    private int scrNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        scrBox = new GameObject[]
        {
            scr1, scr2, scr3, scr4, scr5, scr6, scr7
        };

        barNum_s = StageSelectController.getBarNum();
        // 表示取得
        for (int i = 0; i < 20; i++)
        {
            scrBox[scrNum].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
		{
            barNum_s = StageSelectController.getBarNum();

            for (int i = 0; i < 20; i++)
			{
                scrBox[scrNum].SetActive(false);
			}

            switch (barNum_s)
            {
                case 0:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 1:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 2:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 3:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 4:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 5:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 6:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 7:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 8:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 9:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 10:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 11:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 12:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 13:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 14:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 15:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 16:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 17:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 18:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                case 19:
                    // 表示取得
                    scrBox[scrNum].SetActive(true);
                    break;
                default:
                    break;
            }
        }
    }
}
