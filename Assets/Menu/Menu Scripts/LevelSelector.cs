using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public int levelX;
    public int levelY;
    public Text levelName;

    // Load Level = map name at every button name
    void Start()
    {
        levelName.text = "map" + levelX.ToString() + "_c" + levelY.ToString();
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("map" + levelX.ToString() + "_c" + levelY.ToString());
    }
}
