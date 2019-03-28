using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public PlayerMovement movement;
    public float forwardForce;
    public float sidewaysForce;


    // Use this for initialization
    void Start ()
    {

        Debug.Log("IT WORKS YAY");//Shows info to Console

        //rb.useGravity = false; //turns of gravity

        //rb.AddForce(0, 0, 2000 * Time.deltaTime);

    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    //We marked this as "Fixed Update" cuz we are
    // u use it for mess with physics
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -0.1f)
        {
            FindObjectOfType<GameManager>().EndGame("FAIL");
        }

    }
}
