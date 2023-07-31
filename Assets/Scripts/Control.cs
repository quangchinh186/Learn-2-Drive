using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    public static float speed = 20.0f;

    public Vector2 startPos;
    public float desiredDuration = 5.0f;
    public float eslapsedTime = 0.0f;

    public static float topBonusSpeed = 70.0f;

    private bool speedOn;
    private bool brakeOn;
    //public Time.deltaTime;
    [SerializeField]
    private AnimationCurve curve;
    
    public float bonusSpeed = 0.0f;

    public float topSpeed = 0.0f;

    void Start()
    {
        speedOn = false;
        brakeOn = false;
    

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.touchCount > 0)
        {
            //for(int i = 0; i < Input.touchCount; i++)
            //{
                Touch touch = Input.GetTouch(0);
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        // Record initial touch position.
                        startPos = touch.position;
                        if(startPos.x > Screen.width/2)
                        {
                            speedOn = true;
                        }
                        else
                        {
                            brakeOn = true;
                            //(float)direction.magnitude/5 < -20 ? -20 : - (float)direction.magnitude/5;
                        }
                        break;
                    
                    case TouchPhase.Ended:
                        //eslapsedTime = 0;

                        brakeOn = speedOn = false;
                        topSpeed = bonusSpeed;
                        //bonusSpeed = 0;
                        break;
                }


            if(speedOn)
            {
                eslapsedTime = eslapsedTime + Time.deltaTime > 5 ? 5 : eslapsedTime + Time.deltaTime;
                float percentage = eslapsedTime / desiredDuration;
                bonusSpeed = Mathf.Lerp(0, 70, curve.Evaluate(percentage));
            }

            if(brakeOn)
            {

                bonusSpeed = bonusSpeed - 0.14f < 0 ? 0 :bonusSpeed - 0.14f;
                //if(bonusSpeed < 0) eslapsedTime = 0;
                eslapsedTime = bonusSpeed/topBonusSpeed * desiredDuration;
                // change elapsedTime to spec with bonus speed
            }

            speed = 20.0f + bonusSpeed;
        }
        else
        {
            
            if(!speedOn &  bonusSpeed > 0) 
            {
                eslapsedTime -= Time.deltaTime;
                float percentage = eslapsedTime / desiredDuration;
                bonusSpeed = Mathf.Lerp(topSpeed, 0, Mathf.SmoothStep(1,0,percentage));                   
            }
            
            speed = 20.0f + bonusSpeed;
        }


      
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        
    }




}
