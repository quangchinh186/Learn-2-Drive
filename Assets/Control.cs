using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isRunning = false;
    public float speed = 20.0f;
    void Start()
    {
        isRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            isRunning = !isRunning;
        }
        if(isRunning){
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
    }
}
