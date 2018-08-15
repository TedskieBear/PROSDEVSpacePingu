using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public Text score;
    private int scorecount = 0;
	// Use this for initialization

	public void add(int value){
	    scorecount+=value;
        score.text = "" + scorecount;
	}
}
