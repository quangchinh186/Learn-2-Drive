using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignDisplay : MonoBehaviour
{
    public Sign sign;
    public Text nameDisplay;
    public Image imageDisplay;

    void Start()
    {
        nameDisplay.text = sign.name;
        imageDisplay.sprite = sign.image;
        sign.Display();
    }
}
