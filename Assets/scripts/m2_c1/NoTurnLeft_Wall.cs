using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoTurnLeft_Wall : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isEnabled;

    public Text text;
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player" & !isEnabled)
        {
            text.text = "Recently error: No turn left";
            map2_c1.playerScore--;
            Debug.Log("No turn left" + map2_c1.playerScore);
            isEnabled = true;
        }
            
        
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("Exit No Turn Left Zone");
        isEnabled = false;
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
