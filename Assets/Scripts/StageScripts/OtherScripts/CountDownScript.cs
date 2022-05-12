using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

//カウントダウン
public class CountDownScript : MonoBehaviour
{
	GameObject refObj;
	GameObject refObj2;
	GameObject refObj3;

	private bool endFlag = false;

	GameObject countDown;
	GameObject cloneCount;

	private float AnimSpeed = 0.4f;

	// Start is called before the first frame update
	void Start()
    {
		refObj = GameObject.Find("Player");

		refObj2 = GameObject.Find("fade_white");

		refObj3 = GameObject.Find("Main Camera");

		countDown = (GameObject)Resources.Load("CountDown");
	}

    // Update is called once per frame
    void Update()
    {
		if (refObj2 != null)
		{
			if (refObj2.GetComponent<FadeScript>().fadeEndFlag)
			{
				endFlag = true;
				cloneCount = Instantiate(countDown, new Vector3(refObj3.transform.position.x, refObj3.transform.position.y, 0.0f), Quaternion.identity);
				cloneCount.GetComponent<Animator>().speed = AnimSpeed;
			}
		}

		if(endFlag)
		{
			if (cloneCount.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
				refObj.GetComponent<PlayerScript>().startFlag = true;
			}
		}
	}
}

