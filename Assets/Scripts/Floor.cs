using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    //if wall has been hit, destroy random floor.
    public void Start(){
        FloorManager.instance.AddFloor(this);
    }
}
