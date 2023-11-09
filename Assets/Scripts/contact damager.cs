using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactdamager : MonoBehaviour
{
    public float damage;
    
    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        Life life = other.GetComponent<Life>();
        if(life != null){
            life.amount -= damage;
        }
        
        //if you hit wall or corner inside the parent, create an event.
        if(other.gameObject.layer == 0){
            Debug.Log("hit wall");
            //destroys a random floor.
            int random = Random.Range(0,FloorManager.instance.floors.Count);
            FloorManager.instance.RemoveFloor(FloorManager.instance.floors[random]);
        }
    }
}
