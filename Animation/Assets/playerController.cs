using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    public float jump = 700;
    public float Walk = 30;
    public float MaxWalkSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && rb.velocity.y == 0){
            rb.AddForce(transform.up * jump);
            anim.SetTrigger("JumpTrigger");
        }
        /*
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
        */
        int dir = 0;

        if(Input.GetKey(KeyCode.RightArrow)){
            dir = 1;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            dir = -1;
        }

        float Speed = Mathf.Abs(rb.velocity.x);
        if(Speed < MaxWalkSpeed){
            rb.AddForce(transform.right * dir * Walk);
        }

        if(dir != 0){
            transform.localScale = new Vector3(dir, 1, 1);
        }

        if(transform.position.y < -6 || transform.position.x > 3.5 || transform.position.x < -3.5){
            SceneManager.LoadScene("GameScene");
        }
        if(rb.velocity.y == 0){
            anim.speed = Speed / 2.0f;
        }
        else{
            anim.speed = 1.0f;
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        SceneManager.LoadScene("ClearScene");
    }
}
