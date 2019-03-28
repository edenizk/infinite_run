
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    //public Transform player;

    private void OnCollisionEnter(Collision collision)
    {
        
        //Debug.Log("You hitted");
      
        if(collision.collider.tag == "Obstacle")
        {

            Debug.Log("You hitted Obstacle");
            FindObjectOfType<GameManager>().EndGame("FAIL");
        }

    }

}
