using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour {

    public Rigidbody rb;

    private float horizontal = 0.0f;
    private float vertical = 0.0f;

    public float mov_speed = 10.0f;
    public float jump_force = 10.0f;

    public float fallMult = 2.5f;
    public float lowJumpMult = 2f;

    // Update is called once per frame
    void FixedUpdate () {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.position += horizontal * Vector3.right * Time.deltaTime * mov_speed;
        transform.position += vertical * Vector3.forward * Time.deltaTime * mov_speed;

        Jump();
    }

    void Jump()
    {

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity += Vector3.up * jump_force;

            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector3.up * Physics.gravity.y * (fallMult - 1) * Time.deltaTime;
            }
            else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
            {
                rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMult - 1) * Time.deltaTime;
            }
            else if (rb.velocity.y > 10)
            {
                rb.velocity += Vector3.up * Physics.gravity.y * (fallMult - 1) * Time.deltaTime;
            }
        }

        
    }
}
