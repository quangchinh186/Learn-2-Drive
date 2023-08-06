using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    // Start is called before the first frame update
    private int point;
    private bool helmetOn = false;
    public static bool isSignalLeft = false;
    public static bool isSignalRight = false;
    public Text err;
    static string errCollection; 
    string lastError;

    void Start()
    {
        point = 0;
        lastError = err.text;
    }

    public void showError(){
        Debug.Log(errCollection);
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
        if(err.text != lastError){
            errCollection = errCollection + err.text + '\n';
            lastError = err.text;
            Debug.Log("error: " + errCollection);
        }
    }
}
