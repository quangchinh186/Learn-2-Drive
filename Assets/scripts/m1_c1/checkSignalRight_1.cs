using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class checkSignalRight_1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    public bool isEnabled;

    public bool isRight;

    public Text text;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("PlayerStat.isSignalRight");
            if(PlayerStat.isSignalRight == false && isEnabled == false)
            {
                text.text = "Recent error: Forgor to signal right";
                map1_c1.playerScore -= 1;
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
