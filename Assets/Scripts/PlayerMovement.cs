using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody RB;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
	
	// Update is called once per frame
	void Update () {
        RB.AddForce(0, 0, forwardForce * Time.deltaTime);

        if( Input.GetKey("d") )
        {
            RB.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            RB.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (RB.position.y < 0.9f)
        {
            FindObjectOfType<GameManager>().gameOver();
        }

    }
}
