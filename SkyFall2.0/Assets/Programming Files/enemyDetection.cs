using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDetection : MonoBehaviour
{
    public Transform Player;
    
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag != "Coin"){
              Destroy(Player.gameObject);
        }
     
          
            
        


    }

}
