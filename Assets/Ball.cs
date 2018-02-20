using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    public Vector2 startEnforcer;

    public GameObject nextball;

    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb.AddForce(startEnforcer, ForceMode2D.Impulse);
        Winner.balls += 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Split ()
    {
        if (nextball != null)
        {
            GameObject ball1 = Instantiate(nextball, rb.position + Vector2.right/ 4f, Quaternion.identity);
            GameObject ball2 = Instantiate(nextball, rb.position + Vector2.left / 4f, Quaternion.identity);

            ball1.GetComponent<Ball>().startEnforcer = new Vector2(2f, 5f);
            ball2.GetComponent<Ball>().startEnforcer = new Vector2(-2f, 5f);
            Winner.balls += 2;

        } 
        Destroy(gameObject);
        Winner.balls -= 1;
    }
}
