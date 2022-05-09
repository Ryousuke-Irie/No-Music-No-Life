using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

//カウントダウン
public class CountDownScript : MonoBehaviour
{
	public static float CountDownTime;  // カウントダウンタイム
	GameObject refObj;
	GameObject refObj2;
	GameObject numObj3;
	GameObject numObj2;
	GameObject numObj1;
	GameObject cloneNumObj3;
	GameObject cloneNumObj2;
	GameObject cloneNumObj1;

	private bool endFlag = false;

	// Start is called before the first frame update
	void Start()
    {
		CountDownTime = 3.0F;  // カウントダウン開始秒数をセット  
		refObj = GameObject.Find("Player");

		refObj2 = GameObject.Find("fade_white");

		numObj3 = (GameObject)Resources.Load("num3");
		numObj2 = (GameObject)Resources.Load("num2");
		numObj1 = (GameObject)Resources.Load("num1");

		cloneNumObj3 = Instantiate(numObj3, new Vector3(12.5f, 0.0f, 0.0f), Quaternion.identity);
		cloneNumObj2 = Instantiate(numObj2, new Vector3(12.5f, 30.0f, 0.0f), Quaternion.identity);
		cloneNumObj1 = Instantiate(numObj1, new Vector3(12.5f, 60.0f, 0.0f), Quaternion.identity);
	}

    // Update is called once per frame
    void Update()
    {
		if (refObj2 != null)
		{
			if (refObj2.GetComponent<FadeScript>().fadeEndFlag)
			{
				endFlag = true;
			}
		}

		if(endFlag)
		{
			// 経過時刻を引いていく
			CountDownTime -= Time.deltaTime;

			if (CountDownTime > 0.0F)
			{
				cloneNumObj3.transform.position -= new Vector3(0.0f, 30 * Time.deltaTime, 0.0f);
				cloneNumObj2.transform.position -= new Vector3(0.0f, 30 * Time.deltaTime, 0.0f);
				cloneNumObj1.transform.position -= new Vector3(0.0f, 30 * Time.deltaTime, 0.0f);
			}

			// 0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）
			if (CountDownTime <= 0.0F)
			{
				CountDownTime = 0.0F;
				refObj.GetComponent<PlayerScript>().startFlag = true;

				Destroy(cloneNumObj3);
				Destroy(cloneNumObj2);
				Destroy(cloneNumObj1);
			}
		}
	}
}

