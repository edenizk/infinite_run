using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Vector3 offset;

    // Use this for initialization
    void Start () {

        transform.position = FindObjectOfType<PlayerMovement>().transform.position + offset;

	}

    // Update is called once per frame
    void Update() {

        transform.position = FindObjectOfType<PlayerMovement>().transform.position + offset;

        



    }
}
