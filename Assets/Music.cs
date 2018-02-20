using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Music : MonoBehaviour {

    public AudioMixer master;
    public AudioSource music;
    public float timeDelay;
    public float volume;
    public float initial = 0;
    public bool start = true;
    public bool startMusic = true;

    private void Awake()
    {
        master.GetFloat("volume", out volume);
        master.SetFloat("volume", initial);
    }

    /* Tried to get out beginning cut of music, still trying */
    private void Update()
    {
        if (start)
        {
            music.Play();
            start = false;
            return;
        } else if (timeDelay >= 0)
        {
            timeDelay -= Time.deltaTime;
            return;
        } else if (startMusic)
        {
            master.SetFloat("volume", volume);
            startMusic = false;
            return;
        }
        return;
    }
}
