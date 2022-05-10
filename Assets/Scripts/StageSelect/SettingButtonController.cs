using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class SettingButtonController : MonoBehaviour
{
    [Header("�I�u�W�F�N�g1")] public GameObject menu1;
    [Header("�I�u�W�F�N�g2")] public GameObject menu2;
    [Header("�I�u�W�F�N�g3")] public GameObject menu3;
    [Header("�I�u�W�F�N�g4")] public GameObject menu4;
    [Header("�I�u�W�F�N�g5")] public GameObject menu5;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Buttonclick(int number)
	{
        switch (number)
		{
            case 0:
                menu1.SetActive(false);
                menu2.SetActive(false);
                menu3.SetActive(true);
                menu4.SetActive(true);
                menu5.SetActive(false);
                break;
            case 1:
                SceneManager.LoadScene("TitleScene");
                break;
            default:
                break;
		}
	}
}
