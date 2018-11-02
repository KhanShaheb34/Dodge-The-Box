using UnityEngine;

public class CollisionCheck : MonoBehaviour {

	void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "Obstacles")
        {
            FindObjectOfType<GameManager>().gameOver();
        }
    }

}
