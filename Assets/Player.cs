using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour {

    public float speed = 4f;

    public Rigidbody2D rb;

    private float movement = 0;

	// Update is called once per frame
	void Update () {
		movement = Input.GetAxisRaw("Horizontal") * speed;
	}

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.tag == "Ball")
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Chain.playAudio = true;
            Chain.IsFired = false;
        }
    }
}
