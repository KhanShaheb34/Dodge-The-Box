using UnityEngine;

public class EndLevel : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.levelComplete();
    }
	
}
