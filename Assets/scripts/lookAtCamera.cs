using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lookAtCamera :MonoBehaviour
{
    Transform mainCam;
    Transform target;
    Transform worldSpaceCanvas;
    Vector3 offset = new Vector3(0f, 9f, 0f);


    private void Start ()
    {
        mainCam = Camera.main.transform;
        target = transform.parent;
        worldSpaceCanvas = GameObject.FindObjectOfType<Canvas>().transform;
        transform.SetParent(worldSpaceCanvas);

    }
    void Update ()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - mainCam.transform.position); // look at camera

        transform.position = target.position + offset;

    }
}
