using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Donut : MonoBehaviour {

    // Move speed
    public float speed = 5;
    public Text diamond;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }
	
	// Update is called once per frame
	void Update () {
    
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player"){
            if (this.gameObject.tag == "Diamond"){
                diamond.GetComponentInParent<DiamondScript> ().add();
		        Destroy(this);
            }
            else if (this.gameObject.tag != "Diamond")
                Destroy(col.gameObject);
        }
        else{
            Physics2D.IgnoreLayerCollision(8, 9, true);
        }
    }
}
