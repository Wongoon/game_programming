using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }
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
        if (Input.GetAxisRaw("Vertical") > 0 || Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * Speed * Time.deltaTime, 0f));
        }
        /*
        if (Input.GetKey(KeyCode.RightArrow)){
            Vector3 vec = new Vector3(0.025f, 0.0f, 0.0f);
            transform.localScale = new Vector3(0.15f, 0.15f, 0);
            transform.Translate(vec);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            Vector3 vec = new Vector3(-0.025f, 0.0f, 0.0f);
            transform.localScale = new Vector3(-0.15f, 0.15f, 0);
            transform.Translate(vec);
        }
        if (Input.GetKey(KeyCode.UpArrow)){
            Vector3 vec = new Vector3(0.0f, 0.025f, 0.0f);
            transform.Translate(vec);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            Vector3 vec = new Vector3(0.0f, -0.025f, 0.0f);
            transform.Translate(vec);
        }
        */
        /*
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal") * 0.05f, Input.GetAxis("Vertical") * 0.05f, 0.0f);
        transform.Translate(vec);
        */
        /*
        if(Input.GetAxis("Horizontal") < 0 && transform.localScale.x > 0){
            transform.localEulerAngles = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        else if(Input.GetAxis("Horizontal") > 0 && transform.localScale.x < 0){
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        */
        /*
        if(Input.GetAxis("Horizontal") < 0 && transform.localScale.x > 0){
            Vector3 characterScale = transform.localScale;
            characterScale.x *= -1;
            transform.localScale = characterScale;
        }
        else if(Input.GetAxis("Horizontal") > 0 && transform.localScale.x < 0){
            Vector3 characterScale = transform.localScale;
            characterScale.x *= -1;
            transform.localScale = characterScale;
        }
        */

        if(Input.GetKeyDown(KeyCode.P)){
            Vector3 characterScale = transform.localScale;
            characterScale.x += 0.2f;
            characterScale.y += 0.2f;
            transform.localScale = characterScale;
        }
        if(Input.GetKeyDown(KeyCode.M)){
            Vector3 characterScale = transform.localScale;
            if(characterScale.x - 0.2f > 0 && characterScale.y - 0.2f > 0){
                characterScale.x -= 0.2f;
                characterScale.y -= 0.2f;
            }
            transform.localScale = characterScale;
        }
    }
}