using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 catPos = cat.transform.position;
        if(catPos.y >= 0){
            transform.position = new Vector3(transform.position.x, catPos.y, transform.position.z);
            if(catPos.y >= 17.0f){
                transform.position = new Vector3(transform.position.x, 17.0f, transform.position.z);
            }
        }
    }
}
