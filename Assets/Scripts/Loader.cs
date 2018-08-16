using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    AudioSource fxSound;
    public AudioClip backMusic;
    
    public void loadGame() {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
        fxSound = GetComponent<AudioSource> ();
        fxSound.Play ();
    }

    public void restartGame() {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void continueGame() {
        SceneManager.UnloadSceneAsync("PauseScreen");
        Time.timeScale = 1;
    }

    public void loadMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    public void loadPauseScreen() {
        SceneManager.LoadScene("PauseScreen", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }

    public void loadGameOverScreen() {
        SceneManager.LoadScene("PauseScreen", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }
}