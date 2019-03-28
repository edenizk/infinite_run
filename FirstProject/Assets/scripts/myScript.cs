using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScript : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        Debug.Log("IT WORKS YAY");//Shows info to Console
        //rb.useGravity = false; //turns of gravity
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
        
        
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);

    }
}
