using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public int level;
    public Text levelName;
    // Start is called before the first frame update
    void Start()
    {
        levelName.text = level.ToString();

    }
    
    public void OpenScene()
    {
        SceneManager.LoadScene("Level " + level.ToString());
    }
    
}
