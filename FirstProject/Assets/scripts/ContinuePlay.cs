using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinuePlay : MonoBehaviour {

    public GameObject completeLevelUI;


    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        completeLevelUI.SetActive(false);

    }
}
