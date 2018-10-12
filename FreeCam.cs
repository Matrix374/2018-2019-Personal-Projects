using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCam : MonoBehaviour {

    public Transform player;

    public Camera cam;

    public float speed = 1.0f;

    private float mouseX = 0.0f;
    private float mouseY = 0.0f;

    // Update is called once per frame
    void Update () {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
    }
}
