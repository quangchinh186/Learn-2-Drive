using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoStop_Wall : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float playerSpeed;
    public bool isEnabled;
    public GameObject player;

    public Text text;

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player" & !isEnabled)
        {
            string dir = ReturnDirection.direction(gameObject, other.gameObject);
            Debug.Log(dir);
            if(playerSpeed <= 0) 
            {
                map2_c1.playerScore--;
                text.text = "Recently error: Cant stop here man";
                Debug.Log("Cant stop here man" + map2_c1.playerScore);

                isEnabled = true;
            }
        }
        
    }
    private void OnTriggerExit(Collider other) {
        isEnabled = false;
        Debug.Log("Exit No Stop Zone");
    }
   
    void Start()
    {
        //playerSpeed = 0.0f;
        isEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerSpeed = Control.speed;
    }
}
