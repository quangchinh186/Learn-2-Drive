using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_collision : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            map1_c1.isAlive = false;
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
