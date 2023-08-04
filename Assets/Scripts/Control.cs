using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    public static float speed = 0f;

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
    public Rigidbody rb;
    public Vector3 movement;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        speedOn = false;
        brakeOn = false;
        speedCounter.text = speed.ToString() + "km/h";
    }

    public void bikeBreaks(){
        brakeOn = true;
    }
    public void unBreak(){
        brakeOn = false;
        topSpeed = bonusSpeed;
    }
    public void speedUp(){
        speedOn = true;
    }
    public void speedDown(){
        speedOn = false;
        topSpeed = bonusSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        movement = Vector3.right;
        speedControl();
        speedCounter.text = ((int)speed).ToString() + "km/h";
    }

    void FixedUpdate(){
        moveCharacter(movement);
    }
    void moveCharacter(Vector3 direction){
        rb.velocity = direction * speed;
    }

    void speedControl()
    {
        if(Input.touchCount > 0)
        {    
            if(speedOn)
            {
                eslapsedTime = eslapsedTime + Time.deltaTime > desiredDuration ? desiredDuration : eslapsedTime + Time.deltaTime;
                float percentage = eslapsedTime / desiredDuration;
                bonusSpeed = Mathf.Lerp(lowestSpeed, topBonusSpeed, curve.Evaluate(percentage));
            }
            if(brakeOn)
            {
                bonusSpeed = bonusSpeed - 0.16f < 0 ? 0 :bonusSpeed - 0.16f;
                eslapsedTime = bonusSpeed/topBonusSpeed * desiredDuration;
                lowestSpeed = bonusSpeed;
                if(bonusSpeed <= 0) 
                {
                    eslapsedTime = 0;
                }
            }
           
        }
        else
        {
            if(eslapsedTime > 0) 
            {
                eslapsedTime = eslapsedTime - Time.deltaTime ;
                if(eslapsedTime < 0) eslapsedTime = 0;
                float percentage = eslapsedTime / desiredDuration;
                bonusSpeed = Mathf.Lerp(topSpeed, 0, Mathf.SmoothStep(1,0,percentage));                   
            }      
            
        }
        speed = bonusSpeed;
    }

}



