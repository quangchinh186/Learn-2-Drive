using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    // Start is called before the first frame update
    private int point;
    private bool helmetOn = false;
    public bool isSignalLeft = false;
    public bool isSignalRight = false;

    void Start()
    {
        point = 0;
    }

    public void wearHelmet(bool tog) {
        helmetOn = tog;
        Debug.Log("is wearing helmet: "+ helmetOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
