using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour {

    public static int balls = 0;

	public void Update()
    {
        if (balls <= 0)
        {
            this.gameObject.SetActive(true);
        }
    }
}
