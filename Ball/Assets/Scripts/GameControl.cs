using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl : MonoBehaviour {

    public float score;
    public float winScore;
    public Text scoreText;

    // Use this for initialization
    void Start () {
        scoreText.text = "0";
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public float getScore()
    {
        return score;
    }

    public void decreaseScore()
    {
        score--;
        
        scoreText.text = score.ToString();
    }

    public void increaseScore()
    {
        score++;
        if (score >=winScore)
        {
            //end game
        }
        scoreText.text = score.ToString();
    }
}
