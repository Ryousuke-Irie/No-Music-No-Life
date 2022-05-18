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

    private float ySpeed_config = 10.0f;
    private bool transFlag = false;
    private bool transFlagR = false;

    SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        soundManager = FindObjectOfType<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transFlag == true)
        {
            menu4.transform.position += new Vector3(0.0f, -ySpeed_config * Time.deltaTime, 0.0f);
            if (menu4.transform.localPosition.y < 1.38f)
            {
                menu4.transform.localPosition = new Vector3(-0.4079f, 1.38f, 0.0f);
                menu5.SetActive(true);
                transFlag = false;
            }
        }

        if (transFlagR == true)
        {
            menu4.transform.position += new Vector3(0.0f, ySpeed_config * Time.deltaTime, 0.0f);
            if (menu4.transform.localPosition.y > 11.4f)
            {
                menu4.transform.localPosition = new Vector3(-0.4079f, 11.4f, 0.0f);
                transFlagR = false;
            }
        }
    }

    public void Buttonclick(int number)
	{
        switch (number)
		{
            case 0:
                if(mStatus == false && transFlagR == false)
				{
                    menu1.SetActive(false);
                    menu2.SetActive(false);
                    menu3.SetActive(false);

                    anim.SetBool("start", true);

                    transFlag = true;

                    mStatus = true;
                }
                else if(mStatus == true && transFlag == false)
				{
                    menu1.SetActive(true);
                    menu2.SetActive(true);
                    menu3.SetActive(true);
                    menu5.SetActive(false);

                    anim.SetBool("start", false);

                    transFlagR = true;

                    mStatus = false;
                }
                break;
            case 1:
                if(mStatus == false)
				{
                    soundManager.StopBgm();
                    soundManager.StopSe();
                    SceneManager.LoadScene("TitleScene");
                }
                break;
            default:
                break;
		}
	}
}