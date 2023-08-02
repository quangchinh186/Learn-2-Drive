using UnityEditor;
using System.Linq;
using UnityEngine;

public class M1_c1 : MonoBehaviour
{
    private bool car_1Move = false;
    private void Car1Move()
    {
        GameObject moveToObject = GameObject.FindGameObjectWithTag("moveToObject");
        GameObject[] cars = GameObject.FindGameObjectsWithTag("car_1");
        foreach (GameObject car in cars)
        {
            Debug.Log("counting....");
            car.transform.LookAt(moveToObject.transform.position);
            car.transform.Translate(Vector3.forward * 20.0f * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Tags>(out var tags))
        {
            if (tags.HasTag("wall_1"))
            {
                car_1Move = true;
            }
        }
    }

    private void Update()
    {
        if (car_1Move)
        {
            Car1Move();
        }
    }
}