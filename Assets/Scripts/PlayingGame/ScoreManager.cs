using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // test textmeshpro for text
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    // assigning variables
    public TMP_Text scoreText;
    public TMP_Text highscoreText;

    public int score = 0;
    int highscore = 0;

    private void Awake() // makes sure its run when the program starts
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        // sets a preferred value when no value has been assigned
        highscore = PlayerPrefs.GetInt("highscore", 0);
        //Produces text for score and highscore on screen
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoint()
    {
        // add one to scoere
        score++;
        //update onscreen value
        scoreText.text = score.ToString() + " POINTS";
        //check if score is bigger than current highscore
        if (highscore < score)
        {
            // set the preferred value to the current score so the highscore stays even if you close the program
            PlayerPrefs.SetInt("highscore", score); 
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
