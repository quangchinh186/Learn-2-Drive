using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightControl : MonoBehaviour
{
    public Text timeCounter;
    float duration = 20.0f; 
    Color[] cls = {Color.red, Color.green};
    float timer;
    [SerializeField]
    public int currentColor;

    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
        timer = duration;
        lt.color = cls[currentColor];
        timeCounter.color = cls[currentColor];
    }

    void Update()
    {
        // set light color
        //Debug.Log(timer);
        if(timer > 0){
            timer -= Time.deltaTime;
            timeCounter.text = (timer).ToString();
        } else {
            currentColor = currentColor == 0 ? 1 : 0;
            timer = duration;
            lt.color = cls[currentColor];
            timeCounter.color = cls[currentColor];
        } 
        
    }
}
