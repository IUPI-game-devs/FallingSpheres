using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloorManager : MonoBehaviour
{
    public static FloorManager instance;
    public List<Enemy> floors;
    public UnityEvent onChanged;

    // Simpleton design pattern.
    void Awake(){
        if(instance == null){
            instance = this;
        }
        else{
            Debug.LogError("Duplicated Floor Managers",gameObject);
        }
    }

    public void AddEnemy(Enemy enemy){
        floors.Add(enemy);
        onChanged.Invoke();
    }

    public void RemoveEnemy(Enemy enemy){
        floors.Remove(enemy);
        onChanged.Invoke();
    }
}