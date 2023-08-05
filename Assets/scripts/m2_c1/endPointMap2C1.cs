using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endPointMap2C1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            map2_c1.isCompleted = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
