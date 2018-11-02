using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("escape"))
        {
            backToMenu();
        }
        if (Input.GetKey("w"))
        {
            restartGame();
        }
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void restartGame()
    {
        SceneManager.LoadScene("Level01");
    }
}
