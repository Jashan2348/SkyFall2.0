using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdMovement : MonoBehaviour
{
    //V A R I A B L E S
    public Transform bird;
    public float speed = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       backAndForth();
    
        bird.transform.position = new Vector3((bird.position.x + speed), bird.position.y + 0 ,bird.position.z + 0);



    }
    void backAndForth(){

         if(bird.position.x >= .974){
            speed = speed * -1;
        }
        else if (bird.position.x <= -1.58){
            speed = 0.01f;
        }

    }
}
