using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoTurnLeft_Wall : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isEnabled;

    
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player" & !isEnabled)
        {
            map2_c1.playerScore--;
            Debug.Log("No turn left" + map2_c1.playerScore);
            isEnabled = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("Exit No Turn Left Zone");
    }
    void Start()
    {
        isEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
