using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	public void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex < 5)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            SceneManager.LoadScene("GameComplete");
    }

}
