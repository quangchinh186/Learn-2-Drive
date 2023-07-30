using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CapControl : MonoBehaviour
{
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
        //use this to automate vehicle
        if(Input.GetMouseButtonDown(1))
        {
            Ray movePosistion = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(movePosistion, out var hitInfo))
            {
                agent.SetDestination(hitInfo.point);
            }
        }
    }
}
