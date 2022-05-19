using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class SoundController : MonoBehaviour
{
    public enum VolumeType { MASTER, BGM, SE }

    public static float value_all = 0.5f;
    public static float value_bgm = 0.5f;
    public static float value_se = 0.5f;

    [SerializeField]
    VolumeType volumeType = 0;

    Slider slider;
    SoundManager soundManager;



    void Start()
    {
        slider = GetComponent<Slider>();
        soundManager = FindObjectOfType<SoundManager>();
    }

    public void OnValueChanged()
    {
        switch (volumeType)
        {
            case VolumeType.MASTER:
                soundManager.Volume = slider.value * 0.1f;
                value_all = slider.value * 0.1f;
                break;
            case VolumeType.BGM:
                soundManager.BgmVolume = slider.value * 0.1f;
                value_bgm = slider.value * 0.1f;
                break;
            case VolumeType.SE:
                soundManager.SeVolume = slider.value * 0.1f;
                value_se = slider.value * 0.1f;
                break;
        }
    }

    public float GetValueAll()
	{
        return value_all;
    }
    public float GetValueBGM()
    {
        return value_bgm;
    }
    public float GetValueSE()
    {
        return value_se;
    }
}
