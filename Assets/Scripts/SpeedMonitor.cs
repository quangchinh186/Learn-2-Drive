using UnityEngine;
using TMPro;
using System;
public class SpeedMonitor: MonoBehaviour
{
    public float speed = 0; // the variable to display
    public TMP_Text speedText; // The TextMeshPro object to display

    void Start()
    {
        speedText.SetText("CU");
    }


  // Update is called once per frame
    void Update()
    {
        speedText.SetText("speed: " + (int)Control.speed + "km/h");
    }
}