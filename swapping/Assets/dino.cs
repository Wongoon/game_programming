using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dino : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 0.0f;
    Vector3 startPos;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            /* speed = 0.2f; */
            startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0)){
            Vector3 endPos = Input.mousePosition;
            float swipe = endPos.x - startPos.x;
            speed = swipe / 5000.0f;
        }
        transform.Translate(speed, 0, 0);
        speed *= 0.98f;
    }
}
