using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donut : MonoBehaviour {

    // Move speed
    public float speed = 5;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
            Destroy(this);
    }
}
