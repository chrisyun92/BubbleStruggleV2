using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Chain : MonoBehaviour {

    public static bool IsFired;
    public AudioSource audioSource;
    public float c_speed = 2f;
    public static bool playAudio = true;

    public Transform player;
	// Use this for initialization
	void Start () {
        IsFired = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && playAudio) {
            IsFired = true;
            audioSource.Play();
        }
		if (IsFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * c_speed;
            playAudio = false;
        } else
        {
            transform.position = player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
	}
}
