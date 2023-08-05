using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_forbidden : MonoBehaviour
{
    bool enable = false;
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            if (!enable) {
                score_board_1.score -= 1;
                enable = true;
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
