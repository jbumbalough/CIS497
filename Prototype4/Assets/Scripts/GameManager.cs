using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Text winloss;
    public static bool win = false;
    public static bool loss = false;
    public Text conditions;


    // Start is called before the first frame update
    void Start()
    {
        
        winloss.text = "";
        win = false;
        loss = false;
        Time.timeScale = 0;
 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
            conditions.text = "";
        }

        if(win == true)
        {
            winloss.text = "You win! Press R to restart!";
            if(Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }

        if(loss == true)
        {
            winloss.text = "You lost! Press R to restart!";
            if(Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }
}
