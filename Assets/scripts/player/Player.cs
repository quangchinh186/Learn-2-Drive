using UnityEngine;

public class Player : MonoBehaviour {
    public bool isRunning = false;
    public float speed = 20.0f;
    public bool isMoving = true;
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
        if (other.gameObject.tag == "car_1")
        {
            isRunning = false;
        }
    }

    // Update is called once per frame
    void Update() {
      if (isRunning) {
        move();
      }
/*        if (isMoving)
        {
            CarMove();
        }*/
    }
}