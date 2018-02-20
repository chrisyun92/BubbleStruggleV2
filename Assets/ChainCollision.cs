using UnityEngine;

public class ChainCollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll)
    {
        Chain.IsFired = false;
        if (coll.gameObject.layer == LayerMask.NameToLayer("Ceiling") || coll.tag == "Ball")
        {
            Chain.playAudio = true;
        }
        if (coll.tag == "Ball")
        {
            coll.GetComponent<Ball>().Split();
        }
    }
}
