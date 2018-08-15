using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour {

	public Text mainMenuScore;
	private int HighScorePref;

  void OnEnable() {
      SceneManager.sceneLoaded += OnSceneLoaded;
  }
 
  void OnDisable() {
      SceneManager.sceneLoaded -= OnSceneLoaded;
  }
 
  private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
	   if (scene.name == "MainMenu"){
		  HighScorePref = PlayerPrefs.GetInt("HighScore", 0);
		  mainMenuScore.text = "" + HighScorePref;
	  }
  }
}
