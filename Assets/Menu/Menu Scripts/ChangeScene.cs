using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneButton(string sceneName)
    {
        LevelManager.instance.LoadScene(sceneName);
    }
}
