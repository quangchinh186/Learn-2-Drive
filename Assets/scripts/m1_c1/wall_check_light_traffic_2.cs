using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wall_check_light_traffic_2 : MonoBehaviour
{
    public Text text;
    private void OnTriggerEnter(Collider other) {
        GameObject traffic_light = GameObject.FindGameObjectWithTag("traffic_light");
        LightControl lightControl = traffic_light.GetComponent<LightControl>();
        if (lightControl == null) {
            Debug.Log("timeCounter is null");
            return;
        }
        if (ReturnDirection.direction(gameObject, other.gameObject) == "right") {
            if (lightControl.currentColor == 1) {
                map1_c1.playerScore -= 1;
                text.text = "Recent error: You just pass a redlight";
            }
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
