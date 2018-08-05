using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{
    // Movement speed
    // public float speed = 2;

    // Flap force
    public float force = 300;

    // Use this for initialization
    void Start()
    {
        // Fly towards the right
        // GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        // Pingu used to move, now we'll make it work so that Pingu only moves up and down, but the obstacles are moving -- perceived movement is still the same
    }

    // Update is called once per frame
    void Update()
    {
        // Flap
        if (Input.GetKeyDown(KeyCode.Space))

            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        // Restart
        if (coll.gameObject.name == "ground")
        {
            Application.LoadLevel(Application.loadedLevel); // this should be changed to a game over state :)
        }
        else if (coll.gameObject.name == "Diamond Reward")
        {
            Destroy(coll.gameObject); // destroy the diamond object (make it disappear)
            // add code to add points to player's score
            // diamonds are for currency, added to player's amount at the end of the game proper
        }
        else if (coll.gameObject.name == "Choco Butternut Donut" || coll.gameObject.name == "Strawberry Donut" || coll.gameObject.name == "Bavarian Donut")
        {
            Debug.Log("Game Over");
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}