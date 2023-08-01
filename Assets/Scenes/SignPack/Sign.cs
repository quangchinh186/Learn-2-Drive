using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Sign", menuName = "SignPack/Sign")]

public class Sign : ScriptableObject
{
    public new string name;
    public Sprite image;

    public void Display()
    {
        Debug.Log("Displaying sign: " + name);
    }

}
