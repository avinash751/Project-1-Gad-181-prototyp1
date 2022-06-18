using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public int speed = 1500;
    public int DashSpeed = 20;
    public int jump = 10;
    public bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = 5; // adds more friction , prevents sliding when moving
        
    }

    void Update()
    {
        MovePlayer(); // checks input and moves player
        Jump();// checks input, makes player jump
    }


    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(speed * Time.deltaTime, 0, 0));
            DashOnShift(DashSpeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-speed * Time.deltaTime, 0, 0));
            DashOnShift(-DashSpeed);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            rb.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
            grounded = false;
        }    
    }

    void DashOnShift(int dashSpeed) 
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.AddForce(new Vector3(dashSpeed * transform.right.x * Time.deltaTime, 0, 0), ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            grounded = true;
            Debug.Log("floor");
        }   
    }
}
