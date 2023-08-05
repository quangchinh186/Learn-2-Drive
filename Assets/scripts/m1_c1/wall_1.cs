using UnityEngine;

public class wall_1 : MonoBehaviour {
  [SerializeField]
  bool car_1Move = false;

  private void triggerCar1() {
    GameObject car_1 = GameObject.FindGameObjectWithTag("car_1");
    GameObject moveToObject = GameObject.FindGameObjectWithTag("mto1");
    car_1.transform.LookAt(moveToObject.transform.position);
    car_1.transform.Translate(Vector3.forward * 30.0f * Time.deltaTime);
  }
  
  private void OnTriggerEnter(Collider other) {
    car_1Move = true;
  }

  private void OnTriggerExit(Collider other) {
    
  }

  private void Update() {
    if (car_1Move) {
      triggerCar1();
    }
  }
}