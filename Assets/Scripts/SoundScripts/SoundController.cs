using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public enum VolumeType { MASTER, BGM, SE }

    public static float value_all;
    public static float value_bgm;
    public static float value_se;

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
                soundManager.Volume = slider.value;
                value_all = slider.value;
                break;
            case VolumeType.BGM:
                soundManager.BgmVolume = slider.value;
                value_bgm = slider.value;
                break;
            case VolumeType.SE:
                soundManager.SeVolume = slider.value;
                value_se = slider.value;
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
