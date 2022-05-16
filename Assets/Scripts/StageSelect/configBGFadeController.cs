using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class configBGFadeController : MonoBehaviour
{

	float fadeSpeed = 0.01f;        //�����x���ς��X�s�[�h���Ǘ�

	float temptime = 0.0f;

	private byte alfa;

	public bool isFadeOut = false;  //�t�F�[�h�A�E�g�����̊J�n�A�������Ǘ�����t���O
	public bool isFadeIn = false;   //�t�F�[�h�C�������̊J�n�A�������Ǘ�����t���O

	public byte red = 255, green = 255, blue = 255;

	[System.NonSerialized] public bool fadeEndFlag = false;

	private bool activeFlag = false;

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

	public void Update()
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

	public void StartFadeIn()
	{
			temptime += Time.deltaTime;

			if (temptime > fadeSpeed)
			{
				alfa -= 1;
				temptime = 0.0f;
			}

			SetAlpha();                      //b)�ύX�����s�����x�p�l���ɔ��f����
			if (alfa <= 0)
			{                    //c)���S�ɓ����ɂȂ����珈���𔲂���
				fadeEndFlag = true;
				isFadeIn = false;
			alfa = 255;
			}
	}

	void StartFadeOut()
	{
		temptime += Time.deltaTime;

		if (temptime > fadeSpeed)
		{
			alfa += 1;         // b)�s�����x�����X�ɂ�����
			temptime = 0.0f;
		}

		SetAlpha();               // c)�ύX���������x���p�l���ɔ��f����
		if (alfa >= 255)
		{             // d)���S�ɕs�����ɂȂ����珈���𔲂���
			fadeEndFlag = true;
			isFadeOut = false;
			alfa = 0;
		}
	}

	void SetAlpha()
	{
		this.GetComponent<SpriteRenderer>().color = new Color32(red, green, blue, alfa);
	}
}
