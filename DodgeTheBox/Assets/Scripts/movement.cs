using UnityEngine;

public class movement : MonoBehaviour {

    public Rigidbody rb;
    public float y = 8f;
    public float yTemp = 8f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (y > 0) y--;
        if (y <= 0) {
            yTemp /= 4f;
            y = yTemp;
        }
        rb.AddForce(0, y, 0);
    }
}
