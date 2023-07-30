using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isRunning = false;
    public float speed = 20.0f;

    public Vector2 startPos;
    public Vector2 direction;


    public float bonusSpeed = 0.0f;

    void Start()
    {
        isRunning = true;


    }

    // Update is called once per frame
    void Update()
    {

        if(Input.touchCount > 0)
        {
            

            //for(int i = 0; i < Input.touchCount; i++)
            //{
                Touch touch = Input.GetTouch(0);

                // Move the cube if the screen has the finger moving.
                switch (touch.phase)
                {
                    //When a touch has first been detected, change the message and record the starting position
                    case TouchPhase.Began:
                        // Record initial touch position.
                        startPos = touch.position;
                        break;

                    //Determine if the touch is a moving touch
                    case TouchPhase.Moved:
                        // Determine direction by comparing the current touch position with the initial one
                        if(startPos.x > Screen.width/2)
                        {
                            direction = touch.position - startPos;
                            bonusSpeed = (float)direction.magnitude;
                        }
                        else
                        {
                            bonusSpeed = - (float)direction.magnitude;
                        }
                        break;
                    case TouchPhase.Ended:
                        // Report that the touch has ended when it ends
                        break;
                }


            //}
            


            speed = 20.0f + bonusSpeed;
        }
        else
        {
            speed = 20.0f;
        }





        if(Input.GetKeyDown(KeyCode.W)){
            isRunning = !isRunning;
        }
        if(isRunning){
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
    }
}
