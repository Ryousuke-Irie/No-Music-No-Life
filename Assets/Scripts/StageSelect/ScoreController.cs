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
        // �\���擾
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
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 1:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 2:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 3:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 4:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 5:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 6:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 7:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 8:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 9:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 10:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 11:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 12:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 13:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 14:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 15:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 16:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 17:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 18:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                case 19:
                    // �\���擾
                    scrBox[scrNum].SetActive(true);
                    break;
                default:
                    break;
            }
        }
    }
}
