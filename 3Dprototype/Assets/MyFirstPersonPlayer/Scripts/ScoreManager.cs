/*Josh Bumbalough
 *Assignment 5
 *Script to manage the game winning conditions
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            textbox.text = "You win!";
        }
    }
}
