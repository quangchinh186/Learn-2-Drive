using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endPointMap1C1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            map1_c1.isCompleted = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
