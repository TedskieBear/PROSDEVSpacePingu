using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{
    // Movement speed
    // public float speed = 2;

    // Flap force
    public float force = 300;
    public GameObject bullet;

    // Fire
    public Transform fireButton;
    private float currentAmount;

    // Use this for initialization
    void Start()
    {
        // Fly towards the right
       // GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        // Flap
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();

        if (Input.GetKeyDown("enter")) {
            Fire();
        }
    }

void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name != "Fish")
        {
            // Restart
            Application.LoadLevel(Application.loadedLevel);
            Destroy(this);
        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }

    public void Fire()
    {
        currentAmount = fireButton.GetComponent<FireScript>().currentAmount;
        if (currentAmount >= 100) { 
        GameObject b = (GameObject)(Instantiate(bullet, transform.position + transform.right * 1.5f, Quaternion.identity));

        b.GetComponent<Rigidbody2D>().AddForce(transform.right * 1000);
        
        fireButton.GetComponent<FireScript>().currentAmount = 0;
        }
    }
}