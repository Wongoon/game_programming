using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, 0, 45);
        transform.Translate(-0.05f, -0.05f, 0);

        if(transform.position.y < -6.0f){
            Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other){
        Destroy(gameObject);
    }
}
