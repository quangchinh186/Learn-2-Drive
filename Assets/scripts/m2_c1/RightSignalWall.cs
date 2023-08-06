using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RightSignalWall : MonoBehaviour
{
    // Start is called before the first frame update
    
    public bool isEnabled;
    public Text text;
    public bool isRight;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("PlayerStat.isSignalRight");
            if(PlayerStat.isSignalRight == false && isEnabled == false)
            {
                text.text = "Recently error: You forgor right signal my dude";
                map2_c1.playerScore--;
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
