using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public float lowestSpeed = 0.0f;
    public Text speedCounter;

    void Start()
    {
        speedOn = false;
        brakeOn = false;
        speedCounter.text = speed.ToString() + "km/h";
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
                        }
                        break;      
                    case TouchPhase.Ended:
                        brakeOn = speedOn = false;
                        topSpeed = bonusSpeed;
                        break;
                }
            if(speedOn)
            {
                eslapsedTime = eslapsedTime + Time.deltaTime > desiredDuration ? desiredDuration : eslapsedTime + Time.deltaTime;
                float percentage = eslapsedTime / desiredDuration;
                bonusSpeed = Mathf.Lerp(lowestSpeed, 70, curve.Evaluate(percentage));
            }
            if(brakeOn)
            {
                bonusSpeed = bonusSpeed - 0.16f < -20 ? -20 :bonusSpeed - 0.16f;
                eslapsedTime = bonusSpeed/topBonusSpeed * desiredDuration;
                lowestSpeed = bonusSpeed;
                if(bonusSpeed <= -20) 
                {
                    eslapsedTime = 0;
                }
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
        speedCounter.text = ((int)speed).ToString() + "km/h";
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
