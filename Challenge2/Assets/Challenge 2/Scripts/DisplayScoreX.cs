/*
*Josh Bumbalough
*Assignment2-Challenge2
*Displays the score to player
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScoreX : MonoBehaviour
{
    public Text textbox;
    public int score = 0;
    public static bool gameOver;
    public static bool won;
    // Start is called before the first frame update
    void Start()
    {
        textbox.GetComponent<Text>();
        textbox.text = "Score: 0";
        gameOver = false;
        won = false;
    }

    void Update()
    {
        if(!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        if(score >= 5)
        {
            won = true;
            gameOver = true;
        }

        if(gameOver)
        {
            if(won)
            {
                textbox.text = "You win\nPress R to Try Again";
                Time.timeScale = 0;
            }
            if(Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
