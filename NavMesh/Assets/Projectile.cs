using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetSpeed(float newSpeed){
        speed = newSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
