using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour {

    public Rigidbody rb;

    private float horizontal = 0.0f;
    private float vertical = 0.0f;

    public float mov_speed = 10.0f;
    public float jump_force = 10.0f;
    public float disToGround = 1.0f;

    // Update is called once per frame
    void FixedUpdate () {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.position += horizontal * Vector3.right * Time.deltaTime * mov_speed;
        transform.position += vertical * Vector3.forward * Time.deltaTime * mov_speed;

        if (isGrounded())
        {
            Jump();
        }
    }

    void Jump()
    {

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity += Vector3.up * jump_force;
        }

        
    }

    bool isGrounded()
    {
        bool raycast = Physics.Raycast(transform.position, Vector3.down, disToGround);

        if(!raycast)
        {
            return false;
        }

        return true;
    }
}
