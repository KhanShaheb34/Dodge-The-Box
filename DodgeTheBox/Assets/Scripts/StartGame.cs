using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w"))
        {
            startGame();
        }
        if (Input.GetKey("escape"))
        {
            quitGame();
        }
    }
    public void startGame ()
    {
        SceneManager.LoadScene("Level01");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
