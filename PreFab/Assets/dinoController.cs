using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoController : MonoBehaviour
{
    public int life = 5;
    public GameObject Generator;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float Speed = 10;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Horizontal") < 0)
        {
            if(Input.GetAxisRaw("Horizontal") > 0){
                transform.localEulerAngles = new Vector3(0, 0, 0);
                transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Speed * Time.deltaTime, 0f, 0f));
            }
            else if(Input.GetAxisRaw("Horizontal") < 0){
                transform.localEulerAngles = new Vector3(0, 180, 0);
                transform.Translate(new Vector3(-Input.GetAxis("Horizontal") * Speed * Time.deltaTime, 0f, 0f));
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        life -= 1;
        if(life <= -1){
            Destroy(gameObject);
            Destroy(Generator);
        }
    }
}
