using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public float TurnSpeed = 1.0f;
    public float defaultRotateAngle = 90.0f;

    void Start(){
        Input.gyro.enabled = true;
    }

    void Update() {
        //Debug.Log(Input.acceleration.x);
        float turnValue = Input.acceleration.x * 100;
        if(Mathf.Abs(turnValue) < 20){
            turnValue = 0;
        }
        //Debug.Log(turnValue);
        transform.Rotate(Vector3.up, turnValue * Time.deltaTime);
    }

    
}
