using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightControl : MonoBehaviour
{
    public Text timeCounter;
    public float duration;
    float timer;
    int currentColor = 0;
    Color[] cls = {Color.red, Color.yellow, Color.green, Color.yellow};

    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
        timer = duration;
        timeCounter.color = cls[currentColor];
    }

    void Update()
    {
        // set light color
        Debug.Log(timer);
        if(timer > 0){
            timer -= Time.deltaTime;
            timeCounter.text = timer.ToString();
        } else {
            if(currentColor == 3){
                currentColor = 0;
            } else {
                currentColor++;
            }
            timer = duration;
            lt.color = cls[currentColor];
            timeCounter.color = cls[currentColor];
        } 
        
    }
}
