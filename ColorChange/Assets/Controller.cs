using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Generator gen;
    MeshRenderer MR;
    int colorIndex;

    public void Setup(Generator gen){
        this.gen = gen;
        MR = GetComponent<MeshRenderer>();
        MR.material.color = this.gen.cubeColors[0];
        colorIndex = 0;
    }
    
    public void ChangeColor(){
        if(colorIndex < gen.cubeColors.Length - 1){
            colorIndex++;
        }
        else{
            colorIndex = 0;
        }
        MR.material.color = gen.cubeColors[colorIndex];
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
