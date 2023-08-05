using UnityEngine;

public class wall_1 : MonoBehaviour {
  [SerializeField]
  bool car_1Move = false;

  private void triggerCar1() {
    GameObject car_1 = GameObject.FindGameObjectWithTag("car_1");
    GameObject moveToObject = GameObject.FindGameObjectWithTag("mto1");
    car_1.transform.LookAt(moveToObject.transform.position);
    car_1.transform.Translate(Vector3.forward * 25.0f * Time.deltaTime);
  }
  
  private void OnTriggerEnter(Collider other) {
    car_1Move = true;
  }

  private void OnTriggerExit(Collider other) {
    if (!wall_check_1.pass) {
      score_board_1.score -= 1;
    }
  }

  private void Update() {
    if (car_1Move) {
      triggerCar1();
    }
    Debug.Log("hai");
    Debug.Log(score_board_1.score);
  }
}