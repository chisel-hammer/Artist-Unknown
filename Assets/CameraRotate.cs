using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {
    public Transform target; // the target object
    public Transform controller;
    public float speedMod = 20.0f; // a speed modifier
    private Vector3 point; // the coord to the point where the camera looks at

    private Vector3 direction; // the direction the camera is moving in

    // Set up things on the start method
    void Start()
    {
        point = target.position; // get target's coords
        transform.LookAt(point); // makes the camera look to it
        // controller.LookAt(point);
    }

    // makes the camera rotate around "point" coords, rotating around its Y axis, 20 degrees per second times the speed modifier
    void Update()
    {
        direction = Vector3.zero;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            direction = Vector3.down;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            direction = Vector3.up;
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            direction = Vector3.Cross(Vector3.ProjectOnPlane(transform.forward, Vector3.up), Vector3.down);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            direction = Vector3.Cross(Vector3.ProjectOnPlane(transform.forward, Vector3.up), Vector3.up);
        }

        transform.RotateAround(target.position, direction, speedMod * Time.deltaTime);
        // controller.position = transform.position + transform.forward * 0.35F;
        // controller.position -= new Vector3(0, 0.3F, 0);
    }
}
