using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggle : MonoBehaviour
{
    // Start is called before the first frame update
    Image image;
    void Start()
    {
        image = GetComponent<Image>();
    }

    public void changeColor(bool isOn){
        if(image == null) return;
        Debug.Log(isOn);
        if(isOn){
            image.color = Color.green;
        } else {
            image.color = Color.red;
        }
    }
}
