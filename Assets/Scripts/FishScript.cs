using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
		if (col.gameObject.tag != "Diamond(Clone)" && col.gameObject.name != "Pingu")
        	Destroy(col.gameObject);
    }
}
