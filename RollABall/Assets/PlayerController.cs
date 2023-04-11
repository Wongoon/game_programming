using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float jump;
    public int itemCount = 0;
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && rb.velocity.y == 0){
            rb.AddForce(Vector3.up * jump);
        }

        if(transform.position.y < -2){
            transform.position = new Vector3(0, 0.1f, 0);
        }
    }

    void FixedUpdate(){
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rb.AddForce(new Vector3(h, 0, v) * speed);
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Finish"){
            if(manager.TotalItemCount == itemCount){
                SceneManager.LoadScene("Stage" + (manager.Stage + 1));
            }
            else{
                SceneManager.LoadScene("Stage" + (manager.Stage));
            }
        }
    }
}
