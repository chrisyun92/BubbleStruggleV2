using UnityEngine;

public class ChainCollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll)
    {
        Chain.IsFired = false;
        if (coll.tag == "Ball")
        {
            coll.GetComponent<Ball>().Split();
        }
    }
}
