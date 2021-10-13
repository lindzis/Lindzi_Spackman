using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    // horizontal speed, can be edited in the Inspector
    [SerializeField]
    float speedH = 2.0f;
    // vertical speed, can be edited in the Inspector
    [SerializeField]
    float speedV = 2.0f;

    float yaw = 0f;
    float pitch = 0f;

    // Update is called once per frame
    void Update()
    {
        // the rotation will only work when the left mouse button is held down
        if (Input.GetMouseButton(0))
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            // apply the rotation of the camera based on the mouse movement
            transform.eulerAngles = new Vector3(pitch, yaw, 0f);
        } 
    }
}
