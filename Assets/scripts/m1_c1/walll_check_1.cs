using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walll_check_1 : MonoBehaviour
{
    GameObject car_1 = GameObject.FindGameObjectWithTag("car_1");
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "car_1") {
            
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
