using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool isGameOver = false;
    public PlayerMovement movement;
    public float restartDelay = 1f;
    public GameObject completeLevelDialogue;

    public void levelComplete()
    {
        completeLevelDialogue.SetActive(true);
    }

    public void gameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            movement.enabled = false;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene("Dead");
    }

}
