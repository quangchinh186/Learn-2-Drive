using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blink : MonoBehaviour
{
    public Sprite empty;
    public Sprite filled;
    public Image cur;
    bool isOn;
    float duration = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        cur = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isOn){
            if(duration > 0){
                duration -= Time.deltaTime;
            } else {
                duration = 0.5f;
                cur.sprite = cur.sprite == filled ? empty : filled;
            }
        } else {
            cur.sprite = empty;
        }
        
    }

    public void TurnOn(){
        isOn = true;
    }

    public void TurnOff(){
        isOn = false;
    }

}
