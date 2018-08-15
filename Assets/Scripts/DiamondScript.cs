using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondScript : MonoBehaviour {

	public Text diamond;
    private int diamondcount = 0;

	// Use this for initialization

	public void add(){
	    diamondcount++;
        diamond.text = "" + diamondcount;
	}

}
