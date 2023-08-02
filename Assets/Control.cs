using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isRunning = false;
    public float speed = 20.0f;
    public bool isMoving = false;
    void Start()
    {
        isRunning = true;
    }

    void move() {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * speed);
        }
    }

    private void CarMove()
    {
        GameObject moveToObject = GameObject.FindGameObjectWithTag("moveToObject");
        GameObject car = GameObject.FindGameObjectWithTag("car_1");
        car.transform.LookAt(moveToObject.transform.position);
        car.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "wall")
        {
            return;
        }
        isMoving = true;
    }

    // Update is called once per frame
    void Update() {
        move();     
        if (isMoving)
        {
            CarMove();
        }
    }
}
