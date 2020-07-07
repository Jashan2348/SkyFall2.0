using System.Collections;
using UnityEngine;



public class coinCounter : MonoBehaviour
{

    public float coinCount = 0;
    void OnTriggerEnter2D(Collider2D other){
      
            Destroy(other.gameObject);
            coinCount = coinCount + 1;
            Debug.Log(coinCount);
        


    }
}


