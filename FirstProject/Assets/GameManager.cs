using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public Vector3 offsetAfterHitting;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("Game Won");

        completeLevelUI.SetActive(true);

        EndGame("WON");
    }

    public void EndGame(string status)
    {

        Debug.Log("Game Over");

        FindObjectOfType<PlayerMovement>().movement.enabled = false;

        if(status == "WON")
        {

            FindObjectOfType<Score>().txtScore.color = Color.green;


        }

        else
        {

            FindObjectOfType<Score>().txtScore.color = Color.red;

            FindObjectOfType<FollowPlayer>().transform.position = FindObjectOfType<PlayerMovement>().transform.position + offsetAfterHitting;

            Invoke("Restart", restartDelay);

        }
        
    }

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
