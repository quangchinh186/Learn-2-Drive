using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map2_c1 : MonoBehaviour
{

    public float score;
    Text playerPoint;
    public static float playerScore = 4.0f;
    public static bool isAlive = true;
    
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
        playerPoint.text = playerScore.ToString() + "/4";
        if(playerScore <= 2)
        {
            isAlive = false;
        }
        if(!isAlive)
        {
            Debug.Log("Im dead AF");
        }

    }
}
