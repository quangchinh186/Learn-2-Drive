using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu_UI;

    public static PauseMenu instance;

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

    public void ShowPauseMenu()
    {
        Debug.Log("Pause");
        pauseMenu_UI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Debug.Log("Resume");
        pauseMenu_UI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        Debug.Log("Restart");
        Time.timeScale = 1f;
        SceneManager.LoadScene(gameObject.scene.name);
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
        SceneManager.LoadScene("Mode-1-Menu");
    }
}
