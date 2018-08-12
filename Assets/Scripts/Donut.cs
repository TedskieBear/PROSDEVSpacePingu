using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donut : MonoBehaviour {

    // Move speed
    public float speed = 5;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed * TimeScale.donut;
    }
	
	// Update is called once per frame
	void Update () {
		if(TimeScale.donut == 0.1f)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed * TimeScale.donut;
        }
        if(TimeScale.donut == 1.00f)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed * TimeScale.donut;
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        //Destroy(col.gameObject);

    }
}
