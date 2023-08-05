using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;


public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private Slider slider;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public async void LoadScene(string sceneName)
    {
        var scene = SceneManager.LoadSceneAsync(sceneName);
        scene.allowSceneActivation = false;

        loadingScreen.SetActive(true);

        do
        {
            await Task.Delay(300);
            slider.value = scene.progress;
            Debug.Log(slider.value);
        } while (scene.progress < 0.9f);

        scene.allowSceneActivation = true;
        loadingScreen.SetActive(false);

    }
}
