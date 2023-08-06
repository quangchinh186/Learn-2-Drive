using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map1_c1 : MonoBehaviour
{
    public float score;
    Text playerPoint;
    public static float playerScore = 7.0f;
    public static bool isAlive = true;
    private const float maxPoint = 7.0f;

    public static bool isCompleted = false;

    // Start is called before the first frame update
    
    void Start()
    {
        playerPoint = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        playerPoint.text = playerScore.ToString() + "/" + maxPoint;
        if(playerScore <= maxPoint/2)
        {
            isAlive = false;
        }
        if(!isAlive)
        {
            Debug.Log("Im dead AF");
            InGameMenu.Instance.GameOver();
            //
        }
        if(isCompleted) {
            Debug.Log("Chuyen scene");
            InGameMenu.Instance.NextLevelLoader();
            //chuyen sang scene khac
        }

    }
}
