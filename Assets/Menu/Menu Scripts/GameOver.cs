using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver_UI;

    public static GameOver instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        //hit q to force to game over
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LoadGameOverUI();
        }
    }

    public void LoadGameOverUI()
    {
        //set the game over UI to active
        Debug.Log("Game Over");
        gameOver_UI.SetActive(true);
        Time.timeScale = 0f;

        //set the GameOver-Canvas to active
        GameObject gameOverCanvas = GameObject.Find("GameOver-Canvas");
        gameOverCanvas.SetActive(true);
    }

    public void backToMenu()
    {
        Debug.Log("Back to Menu");
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Mode-1-Menu");
    }

    public void Restart()
    {
        Debug.Log("Restart");
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }


}
