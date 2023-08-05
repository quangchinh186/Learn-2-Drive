using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    // Start is called before the first frame update
    private int point;
    private bool helmetOn = false;
    public static bool isSignalLeft = false;
    public static bool isSignalRight = false;

    void Start()
    {
        point = 0;
    }

    public void wearHelmet(bool tog) {
        helmetOn = tog;
        Debug.Log("is wearing helmet: "+ helmetOn);
    }

    public void stopSignal(){
        isSignalLeft = false;
        isSignalRight = false;
    }

    public void signalLeft(){
        if(isSignalRight) isSignalRight = false;
        isSignalLeft = true;
        Debug.Log("left");
    }

    public void signalRight(){
        if(isSignalLeft) isSignalLeft = false;
        isSignalRight = true;
        Debug.Log("right");
    }
    private void Update() {
        Debug.Log("Stats" + isSignalRight);
    }
}
