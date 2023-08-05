using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Queue<GameObject> targets = new Queue<GameObject> ();
    GameObject currentTarget;
    float speed = 20.0f;
    private void Start()
    {
        
    }

    public void addTarget(GameObject target)
    {
        targets.Enqueue(target);
    }

    public void Move(GameObject target)
    {
        this.currentTarget = target;
        GameObject car = GameObject.FindGameObjectWithTag("car_1");
        car.transform.LookAt(currentTarget.transform.position);
        car.transform.Translate(Vector3.forward * this.speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "moveToObject")
        {
            
        }
    }

    private void Update()
    {
        
    }
}