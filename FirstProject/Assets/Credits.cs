﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

	public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();

    }

    public void PlayAgain()
    {

        SceneManager.LoadScene(1);

    }
}
