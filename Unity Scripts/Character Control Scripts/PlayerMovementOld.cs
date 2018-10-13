using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Transform player;

    public float mov_speed = 10.0f;
    public float jump_force = 10.0f;
    public float gravity = 30.0f;

    private Vector3 moveDir = Vector3.zero;

    private float horizontal = 0.0f;
    private float vertical = 0.0f;
	
	// Update is called once per frame
	void Update () {
        CharacterController controller = gameObject.GetComponent<CharacterController>();

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            moveDir = new Vector3(horizontal, 0, vertical);

            moveDir = transform.TransformDirection(moveDir);

            moveDir *= mov_speed;

            if(Input.GetButtonDown("Jump"))
            {
                moveDir.y -= jump_force;
            }
        }

        moveDir.y *= gravity;

        controller.Move(moveDir * Time.deltaTime);

	}
}
