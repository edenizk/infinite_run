using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text txtScore;
    
    // Update is called once per frame
    void Update () {
        //   Debug.Log(player.position.z);
        if (txtScore.color != Color.red)
        {

            txtScore.text = player.position.z.ToString("0");

        }


    }
}
