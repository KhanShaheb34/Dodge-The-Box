using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreUpdate : MonoBehaviour {

    public Text scoreText;

    public int score = 0;

    // Update is called once per frame
    void Update () {
        scoreText.text = "Level " + (SceneManager.GetActiveScene().buildIndex - 1).ToString();
	}
}
