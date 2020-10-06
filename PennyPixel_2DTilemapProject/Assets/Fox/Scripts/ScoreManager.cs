/*Josh Bumbalough
 *Assignment 5
 *Script to manage the players score
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static int score;
    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!gameOver)
        {
            textbox.text = "Score: " + score;
        }
        
        if(gameOver)
        {
            textbox.text = "You Win!";
        }
    }
}
