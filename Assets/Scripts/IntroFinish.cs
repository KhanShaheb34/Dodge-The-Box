using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroFinish : MonoBehaviour {

	public void introFinish()
    {
        SceneManager.LoadScene("Menu");
    }
}
