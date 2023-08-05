using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_test_side : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log(ReturnDirection.direction(gameObject, other.gameObject));
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
