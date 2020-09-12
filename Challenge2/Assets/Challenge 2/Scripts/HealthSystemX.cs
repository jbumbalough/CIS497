/*
*Josh Bumbalough
*Assignment2-Challenge2
*Displays health to player
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystemX : MonoBehaviour
{
    public Text textbox;
    public int health = 5;
    public static bool gameOver;
    public static bool won;

    // Start is called before the first frame update
    void Start()
    {
        textbox.GetComponent<Text>();
        textbox.text = "Health: 5";
        gameOver = false;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            textbox.text = "Health: " + health;
        }


        if(health <= 0)
        {
            won = false;
            gameOver = true;
        }


        if(gameOver)
        {
            if(won)
            {
                textbox.text = "You win\nPress R to Try Again";
            }
            else
            {
                textbox.text = "You lose\nPress R to Try Again";
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
