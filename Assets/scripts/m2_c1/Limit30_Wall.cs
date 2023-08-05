using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit30_Wall : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isEnabled;
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player" & !isEnabled)
        {
            
            if(Control.speed > 30)
            {
                map2_c1.playerScore--;
                Debug.Log("Exceed speed 30" + map2_c1.playerScore);
                isEnabled = true;
            }
        }
        
    }
    private void OnTriggerExit(Collider other) {
        isEnabled = false;
        Debug.Log("Exit No 30 Zone");
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
