using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particalFollow : MonoBehaviour
{
     public Transform Player;
     public Transform Partical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          Partical.transform.position = new Vector3(Player.position.x,Player.position.y,transform.position.z);
    }
}
