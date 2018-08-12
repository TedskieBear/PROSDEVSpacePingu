using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Donut : MonoBehaviour {

    // Move speed
    public float speed = 5;
    public Text diamond;
    public Text score;

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
            if(col.gameObject.tag == "OutsideBounds"){
                score.GetComponentInParent<ScoreController>().add(10);
		        Destroy(this.gameObject);
            }
        }
    }
}
