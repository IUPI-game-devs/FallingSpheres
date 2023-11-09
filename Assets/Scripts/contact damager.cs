using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactdamager : MonoBehaviour
{
    public float damage;
    
    void OnTriggerEnter(Collider other){
        
        //if you hit wall or corner inside the parent, paint them red
        if(other.gameObject.layer == 0){
            Debug.Log("hit wall");
            GetComponent<Renderer>().material.color = Color.red;
        }
        Destroy(gameObject);
        Life life = other.GetComponent<Life>();
        if(life != null){
            life.amount -= damage;
        }

    }
}
