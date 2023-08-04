using UnityEngine;

public class MoveToTarget : MonoBehaviour {
  [SerializeField]
  GameObject target;
  private bool isMove = false; 
  float speed = 20.0f;

  private void PlayerOnCheck() {
    isMove = true;
  }

  private void Update() {
    if (!target)
    {
      return;
    }  
    transform.LookAt(target.transform.position);
    transform.Translate(Vector3.forward * Time.deltaTime * speed);
  }
}