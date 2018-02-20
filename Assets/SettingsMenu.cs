using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer audiomixer;
    public Slider slider;
    private float oppositeValue;

	public void SetVolume (float vol)
    {
        float volume = vol / 4;
        audiomixer.SetFloat("volume", volume);
    }

    public void Mute ()
    {
        audiomixer.SetFloat("volume", -80);
        slider.value = oppositeValue;
        if (oppositeValue < 0)
        {
            oppositeValue = 0;
        } else
        {
            oppositeValue = -80;
        }
    }
}
