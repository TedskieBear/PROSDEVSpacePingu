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
    private float unlimitedFire = 0.00f;
    private float slowTime = 0.00f;
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
        if (Input.GetKeyDown(KeyCode.Space)){
        Jump();
        }

        /*if (Input.GetKeyDown("enter")) {
            Fire();
        }*/

        if(unlimitedFire > 0.00)
        {
            currentAmount = fireButton.GetComponent<FireScript>().currentAmount;
            unlimitedFire -= Time.deltaTime * 1;
            fireButton.GetComponent<FireScript>().currentAmount = unlimitedFire * 10;
        }

        if (slowTime > 0.00)
        {
            slowTime -= Time.deltaTime * 1;
        }
        else
        {
            TimeScale.donut = 1.00f;
        }
    }

void OnCollisionEnter2D(Collision2D col)
        {
        if (col.gameObject.tag == "Diamond"){
                Destroy(col.gameObject);
        }
        if (col.gameObject.name != "Fish" && col.gameObject.tag != "Diamond")
        {
            // Restart
            Application.LoadLevel(Application.loadedLevel);
            Destroy(this);
        }
        else if (col.gameObject.name == "Diamond Reward(Clone)")
        {
            int choice = Random.Range(0, 3);
            if (choice == 0)
            {
                Debug.Log("Unlifish");
                currentAmount = fireButton.GetComponent<FireScript>().currentAmount;
                fireButton.GetComponent<FireScript>().currentAmount = 100;
            
                unlimitedFire = 10.00f;
            }
            else if (choice == 1)
            {
                Debug.Log("Donut");
                TimeScale.donut = 0.1f;
                slowTime = 5.00f;
            }
            else if (choice == 2)
            {
                Debug.Log("Giant Fish");
                GameObject b = (GameObject)(Instantiate(bullet, transform.position + transform.right * 1.5f, Quaternion.identity));
                b.transform.localScale = new Vector3(3.0f, 3.0f);
                b.GetComponent<Rigidbody2D>().AddForce(transform.right * 1000);
            }
        }
        
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }

    public void Fire()
    {
        
        currentAmount = fireButton.GetComponent<FireScript>().currentAmount;
        if (currentAmount >= 100 || unlimitedFire > 0.00) {
            
            
        GameObject b = (GameObject)(Instantiate(bullet, transform.position + transform.right * 1.5f, Quaternion.identity));

        b.GetComponent<Rigidbody2D>().AddForce(transform.right * 1000);

            if (unlimitedFire <= 0.00)
            {
                fireButton.GetComponent<FireScript>().currentAmount = 0;
            }
        }
    }
}