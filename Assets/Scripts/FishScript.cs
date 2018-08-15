using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
	Physics2D.IgnoreLayerCollision(11, 8, true);
	  if (col.gameObject.tag != "Fish" && col.gameObject.tag != "Diamond" && col.gameObject.tag != "Player")
        {
			Destroy(col.gameObject);
        }
    }
}
