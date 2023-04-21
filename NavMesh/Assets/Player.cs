using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour
{

    public float moveSpeed = 5;
    float hAxis;
    float vAxis;
    Vector3 moveVec;
    Camera viewCamera;
    GunController gunController;

    void Start()
    {
        gunController = GetComponent<GunController>();
        viewCamera = Camera.main;
    }
    void Update()
    {
        GetInput();
        Move();
        Turn();
        
        if (Input.GetMouseButton(0))
        {
            gunController.Shoot();
        }
    }

    void GetInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
    }

    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis);
        transform.position += moveVec * moveSpeed * Time.deltaTime;
        
    }
    void Turn()
    {
        transform.LookAt(transform.position + moveVec);
    }

    
}