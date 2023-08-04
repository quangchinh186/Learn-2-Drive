using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public float TurnSpeed = 40.0f;

    void Start(){
        Input.gyro.enabled = true;
    }

    void Update() {
        Debug.Log(Input.acceleration.x);
        float turnValue = Input.acceleration.x;
        if(Mathf.Abs(turnValue) < 0.1){
            turnValue = 0;
        }
        transform.Rotate(Vector3.up, turnValue * 100 * Time.deltaTime);
    }

    public void run(){
        Debug.Log("running");
        transform.Translate(Vector3.forward * 2.0f);
        
    }

    public void stop(){
        Debug.Log("stop");
    }

    public void turnLeft(){
        Debug.Log("left");
        transform.Rotate(Vector3.up, -TurnSpeed * Time.deltaTime);
    }

    public void turnRight(){
        Debug.Log("Right");
        transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
    }
}
