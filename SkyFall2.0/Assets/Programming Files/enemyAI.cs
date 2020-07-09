using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public Transform player; 
    public Transform cloud;

    public Transform firePoint;

    public float distance;
      

    void Start(){
     distance = Vector3.Distance(player.transform.position, cloud.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        findTarget();
    }

    public void findTarget(){
        float targetRange = 50f;
        if(distance < targetRange){
            Shoot();
        }
    }

    public void Shoot(){
        
    }
}


