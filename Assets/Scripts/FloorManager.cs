using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloorManager : MonoBehaviour
{
    public static FloorManager instance;
    public List<Floor> floors;
    public UnityEvent onChanged;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
