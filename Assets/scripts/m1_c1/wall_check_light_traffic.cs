using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wall_check_light_traffic : MonoBehaviour
{
    private void OnTriggerExit(Collider other) {
        GameObject traffic_light = GameObject.FindGameObjectWithTag("traffic_light");
        LightControl lightControl = traffic_light.GetComponent<LightControl>();
        if (lightControl == null) {
            Debug.Log("timeCounter is null");
            return;
        }
        if (lightControl.currentColor == 0) {
            if (ReturnDirection.direction(gameObject, other.gameObject) == "right") {
                Debug.Log("break rule");
            }
        } else if (lightControl.currentColor == 1) {
            if (ReturnDirection.direction(gameObject, other.gameObject) == "left") {
                Debug.Log("break rule");
            }
        } else {
            Debug.Log("good");
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
