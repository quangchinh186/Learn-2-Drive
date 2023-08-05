using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map2_c1 : MonoBehaviour
{
    public float score;
    Text playerPoint;
    public static float playerScore = 6.0f;
    public static bool isAlive = true;
    private const float maxPoint = 6.0f;

    public static bool isCompleted = false;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        
    }
    void Start()
    {
        playerPoint = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPoint.text = playerScore.ToString() + "/" + maxPoint;
        if(playerScore <= 2)
        {
            isAlive = false;
        }
        if(!isAlive)
        {
            Debug.Log("Im dead AF");
        }
        if(isCompleted) {
            //chuyen sang scene khac
        }

    }
}
