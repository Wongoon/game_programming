using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    public Generator gen;
    public Controller[] touchCubes;
    // Start is called before the first frame update
    void Start()
    {
        touchCubes = GetComponentsInChildren<Controller>();
        for(int i = 0; i < touchCubes.Length; i++){
            touchCubes[i].Setup(gen);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
