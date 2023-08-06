using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_check_1 : MonoBehaviour
{
    public static bool check = false;
    public static bool pass = false;
    // GameObject car_1 = GameObject.FindGameObjectWithTag("car_1");
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "car_1") {
            check = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "car_1") {
            check = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score_board_1.score);
    }
}
