using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour {

    public static bool IsFired;

    public float c_speed = 2f;

    public Transform player;
	// Use this for initialization
	void Start () {
        IsFired = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1")) {
            IsFired = true;
        }
		if (IsFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * c_speed;

        } else
        {
            transform.position = player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
	}
}
