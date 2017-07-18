using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float yaw = 0.0f;
    public float pitch = 0.0f;

    bool FlickIsTrue = false;
    int i = 0;
    private PlayerShoot _playerShoot;
    private void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        if (FlickIsTrue == false)
        {
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.eulerAngles = new Vector3(-20, 0, 0);
            FlickIsTrue = true;
        }
        if (FlickIsTrue == true )
        {
            i = i+1;
            if (i >= 20)
            {
                FlickIsTrue = false;
            }
        }
    }

}
