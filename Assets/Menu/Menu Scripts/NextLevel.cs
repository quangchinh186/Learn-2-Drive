using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject nextLevel_UI;

    public static NextLevel instance;

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
        //hit p to force to load next level ui
        if (Input.GetKeyDown(KeyCode.P))
        {
            LoadNextLevelUI();
        }
    }

    public void LoadNextLevelUI()
    {
        //set the next level UI to active
        Debug.Log("Next Level");
        nextLevel_UI.SetActive(true);
        Time.timeScale = 0f;
        
        //set the GameOver-Canvas to active
        GameObject nextLevelCanvas = GameObject.Find("NextLevel-Canvas");
        nextLevelCanvas.SetActive(true);
    }

    public void backToMenu()
    {
        Debug.Log("Back to Menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Mode-1-Menu");
    }

    public void nextLevel()
    {
        Debug.Log("Next Level");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        Debug.Log("Restart");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
