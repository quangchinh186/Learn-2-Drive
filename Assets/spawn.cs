using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    int numberOfRoad;
    
    public GameObject road;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        numberOfRoad = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 50);
        if((transform.position.x - player.transform.position.x) > 10){
            spawnRoad();
        }
    }

    void spawnRoad(){
        numberOfRoad = numberOfRoad + 1;
        Instantiate(road, transform.position, Quaternion.identity);
    }
}
