using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubemove : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -1) * moveSpeed * Time.deltaTime;
        if(transform.position.z < -11) {
            Destroy(gameObject);
        }
    }
}
