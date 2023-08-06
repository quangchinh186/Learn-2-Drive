using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check_forbidden : MonoBehaviour
{

    public Text text;

    bool enable = false;
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            if (!enable) {
                map1_c1.playerScore -= 1;
                enable = true;
                text.text = "Recent error: In forbidden zone";
            }   
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {
            enable = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
