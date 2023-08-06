using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool GameIsOver = false;
    public static bool isNextLevel = false;

    public GameObject pauseMenuUI;
    public GameObject gameOverUI;
    public GameObject nextLevelUI;
    // Update is called once per frame

    public static InGameMenu Instance;

    void Update()
    {
        //hit escape to pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        //hit q to force to game over
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameOver();
        }
        //hit p to force to load next level ui
        if (Input.GetKeyDown(KeyCode.P))
        {
            NextLevelLoader();
        }
    }
    //show next level

    public void NextLevelLoader()
    {
        //set the next level UI to active
        Debug.Log("Next Level");
        nextLevelUI.SetActive(true);
        Time.timeScale = 0f;
        isNextLevel = true;

        //set the NextLevel-Canvas to active
        GameObject nextLevelCanvas = GameObject.Find("NextLevel-Canvas");
        nextLevelCanvas.SetActive(true);
    }

    //show game over UI
    public void GameOver()
    {
        //set the game over UI to active
        Debug.Log("Game Over");
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsOver = true;

        //set the GameOver-Canvas to active
        GameObject gameOverCanvas = GameObject.Find("GameOver-Canvas");
        gameOverCanvas.SetActive(true);
    }

    public void Resume()
    {
        Debug.Log("Resume");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        Debug.Log("Pause");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        Debug.Log("Back to main menu");
        Time.timeScale = 1f;
        GameIsPaused = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Mode-1-Menu");
    }

    public void NextLevel()
    {
        //load the next index scene
        Debug.Log("Next Level");
        Time.timeScale = 1f;
        GameIsPaused = false;
        // UnityEngine.SceneManagement.SceneManager.LoadScene("Mode-1-Menu");
        UnityEngine.SceneManagement.SceneManager.LoadScene(gameObject.scene.buildIndex + 1);
    }

    public void Restart()
    {
        Debug.Log("Restart");
        Time.timeScale = 1f;
        GameIsPaused = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene(gameObject.scene.name);

    }

    public void Awake() {
        if(Instance == null)
        {
            Instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    
}
