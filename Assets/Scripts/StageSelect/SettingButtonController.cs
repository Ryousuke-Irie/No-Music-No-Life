using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class SettingButtonController : MonoBehaviour
{
    [Header("オブジェクト1")] public GameObject menu1;
    [Header("オブジェクト2")] public GameObject menu2;
    [Header("オブジェクト3")] public GameObject menu3;
    [Header("オブジェクト4")] public GameObject menu4;
    [Header("オブジェクト5")] public GameObject menu5;

    private bool mStatus = false;
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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
                if(mStatus == false)
				{
                    menu1.SetActive(false);
                    menu2.SetActive(false);
                    menu3.SetActive(false);
                    menu4.SetActive(true);
                    menu5.SetActive(false);

                    anim.SetBool("start", true);

                    mStatus = true;
                }
                else if(mStatus == true)
				{
                    menu1.SetActive(true);
                    menu2.SetActive(true);
                    menu3.SetActive(true);
                    menu4.SetActive(false);
                    menu5.SetActive(true);

                    anim.SetBool("start", false);

                    mStatus = false;
                }
                break;
            case 1:
                if(mStatus == false)
				{
                    SceneManager.LoadScene("TitleScene");
                }
                break;
            default:
                break;
		}
	}
}