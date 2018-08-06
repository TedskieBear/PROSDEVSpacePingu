using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X22_OtherScreen : View {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DisplayTestDialog(){
		Debug.Log (("Test"));

		//Display a UI using the View handler system
		ViewHandler.Instance.Show ("X22_OtherScreen2");
	}
}
