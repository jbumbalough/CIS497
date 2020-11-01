using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
   public int score;

   public GameObject pauseMenu;

   public Text text;

   public bool won;
   public bool lost;

    public static float currentTime = 0;
    public static float startingTime = 0;

    private string CurrentLevelName = string.Empty;

    [SerializeField] Text countdownText;

//    public static GameManager instance;
   
//    private void Awake()
//    {
//        if(instance == null)
//        {
//            instance = this;
//            //make sure game manager persitst across scenes
//            DontDestroyOnLoad(gameObject);
//        }
//        else
//        {
//            Destroy(gameObject);
//            Debug.LogError("Trying to instantiate a second instance of singleton game manager");
//        }
//    }

   public void LoadLevel(string levelName)
   {
       AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if(ao == null)
        {
            Debug.LogError("GameManager Unable to Load Level " + levelName);
            return;
        }
        CurrentLevelName = levelName;
        Start();
        Enemy.triggered = false;
   }

   public void UnloadLevel(string levelName)
   {
       AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if(ao == null)
        {
            Debug.LogError("GameManager Unable to unload Level " + levelName);
            return;
        }
   }

   public void UnloadCurrentLevel()
   {
       AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
        if(ao == null)
        {
            Debug.LogError("GameManager Unable to unload Level " + CurrentLevelName);
            return;
        }
   }

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Unpause()
    {

        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
     
    }

    void Start()
    {
        lost = false;
        //won = false;
        Enemy.triggered = false;
        currentTime = startingTime;
        // currentTime = startingTime;
        text.text = "";
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }

        if(Enemy.triggered == true)
        {
            Pause();
            lost = true;
            currentTime += 0;
            if(lost == true)
            text.text = "Game Over! \n Survival Time: " + currentTime + " seconds. Go back to Main Menu to try again!";
        }


        if(CurrentLevelName == "Easy" || CurrentLevelName == "Medium" || CurrentLevelName == "Hard")
        {
            currentTime += 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");
        }
    }
}
