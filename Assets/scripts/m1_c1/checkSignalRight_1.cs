using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkSignalRight_1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    public bool isEnabled;

    public bool isRight;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("PlayerStat.isSignalRight");
            if(PlayerStat.isSignalRight == false && isEnabled == false)
            {
                score_board_1.score -= 1;
                isEnabled = true;
            }
        }
    }
    private void OnTriggerExit(Collider other) {
        isEnabled = false;
    }
    void Start()
    {
        //playerSpeed = 0.0f;
        isEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
