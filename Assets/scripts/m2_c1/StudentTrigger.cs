using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            //run acros the road
            StudentBehavior.isActivated = true;
            Debug.Log("Triggered student");
        }
    }
    
    void Start()
    {
        //playerSpeed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
