using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControls : MonoBehaviour {
    //TANK CONTROLS
    private float horizontal = 0.0f;
    private float vertical = 0.0f;

    public float rotRate = 360.0f;
    public float mov_speed = 10.0f;

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        ApplyInput(vertical,horizontal);
    }

    private void ApplyInput(float moveInput, float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }

    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * mov_speed * Time.deltaTime);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, rotRate * input * Time.deltaTime, 0);
    }
}
