using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreCalculator : MonoBehaviour {

	public Text diamondCount;
	public Text scoreValue;
	public Text totalScore;
	private int diamondCountPref;
	private int scoreValuePref;
	private int total;
	private int HighScorePref;

	public void CalculateScore () {
		scoreValuePref = PlayerPrefs.GetInt("CurrentScore", 0);
		diamondCountPref = PlayerPrefs.GetInt("CurrentDiamonds", 0);
		HighScorePref = PlayerPrefs.GetInt("HighScore", 0);
		total = diamondCountPref * 50 + scoreValuePref;
		scoreValue.text = "" + scoreValuePref;
		diamondCount.text = "" + diamondCountPref;
		totalScore.text = "" + total;
		if (total > HighScorePref)
			PlayerPrefs.SetInt("HighScore", total);
	}
	   void OnEnable() {
      SceneManager.sceneLoaded += OnSceneLoaded;
  }
 
  void OnDisable() {
      SceneManager.sceneLoaded -= OnSceneLoaded;
  }
 
  private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
	  if (scene.name == "GameoverScreen"){
		  CalculateScore();
	  }
  }
}
