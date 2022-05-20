using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{

	float fadeSpeed = 0.01f;        //透明度が変わるスピードを管理

	float temptime = 0.0f;

	private byte alfa;

	public bool isFadeOut = false;  //フェードアウト処理の開始、完了を管理するフラグ
	public bool isFadeIn = false;   //フェードイン処理の開始、完了を管理するフラグ

	public byte red = 255, green = 255, blue = 255;

	[System.NonSerialized] public bool fadeEndFlag = false;

	void Start()
	{
		if (isFadeIn)
		{
			alfa = 255;
		}

		if (isFadeOut)
		{
			alfa = 0;
		}

		this.GetComponent<SpriteRenderer>().color = new Color32(red, green, blue, alfa);
	}

	void Update()
	{
		if (isFadeIn)
		{
			StartFadeIn();
		}

		if (isFadeOut)
		{
			StartFadeOut();
		}
	}

	void StartFadeIn()
	{
		temptime += Time.deltaTime;

		if (temptime > fadeSpeed)
		{
			alfa -= 5;        
			temptime = 0.0f;
		}

		SetAlpha();                      //b)変更した不透明度パネルに反映する
		if (alfa <= 0)
		{                    //c)完全に透明になったら処理を抜ける
			fadeEndFlag = true;
			isFadeIn = false;
			Destroy(gameObject);
		}
	}

	void StartFadeOut()
	{
		temptime += Time.deltaTime;

		if (temptime > fadeSpeed)
		{
			alfa += 5;         // b)不透明度を徐々にあげる
			temptime = 0.0f;
		}

		SetAlpha();               // c)変更した透明度をパネルに反映する
		if (alfa >= 255)
		{             // d)完全に不透明になったら処理を抜ける
			fadeEndFlag = true;
			isFadeOut = false;
		}
	}

	void SetAlpha()
	{
		this.GetComponent<SpriteRenderer>().color = new Color32(red, green, blue, alfa);
	}
}
