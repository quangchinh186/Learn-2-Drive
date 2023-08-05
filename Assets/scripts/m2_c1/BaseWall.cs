using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWall : MonoBehaviour
{
    // Start is called before the first frame update
    
    public bool isEnabled;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            isEnabled = true;
            if(true & isEnabled == false)
            {
                map2_c1.playerScore--;
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
