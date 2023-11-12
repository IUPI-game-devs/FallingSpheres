using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloorManager : MonoBehaviour
{
    public static FloorManager instance;
    public List<Floor> floors;
    public UnityEvent onChanged;
    
    void Awake(){
        if(instance == null){
            instance = this;
        }
        else{
            Debug.LogError("Duplicated Floor Manager",gameObject);
        }
    }

    public void AddFloor(Floor floor){
        floors.Add(floor);
        onChanged.Invoke();
    }

    public void RemoveFloor(Floor floor){
        //delethe the gamobject as well random floor.
        Destroy(floor.gameObject);
        floors.Remove(floor);
        onChanged.Invoke();
    }
}
