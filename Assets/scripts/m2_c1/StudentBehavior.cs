using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isActivated = false;
    private Vector3 direction;
    private const float speed = 6.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();    
        direction = Vector3.left;
    }


    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player")
        {   
            int dirZ = 1;
            if(Control.movement.z < 0)
            {
                dirZ = -1;
            }
            map2_c1.isAlive = false;
            rb.AddForce(0, 200.0f, dirZ * 100.0f, ForceMode.Impulse);
        }
    }
  

    // Update is called once per frame
    void Update()
    {
        if(isActivated)
        {
            Move(direction);
        }
    }

    void FixedUpdate(){
        
    
    }
    void Move(Vector3 direction){
        rb.velocity = direction * speed;
    }
}
