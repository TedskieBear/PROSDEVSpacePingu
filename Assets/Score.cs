using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public float multiplyer;
    public Text score;
    private float currentScore;
    private int displayScore;
	void Start () {
		
	}
	
	void Update () {
        currentScore += Time.deltaTime * multiplyer;
        displayScore = (int)currentScore;
        score.text = displayScore.ToString();
	}
}
