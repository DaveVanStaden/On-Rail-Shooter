using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAim : MonoBehaviour {

    public float BulletspeedH = 2.0f;
    public float BulletspeedV = 2.0f;

    public float Bulletyaw = 0.0f;
    public float Bulletpitch = 0.0f;

    private void Update()
    {
        Bulletyaw += BulletspeedH * Input.GetAxis("Mouse X");
        Bulletpitch -= BulletspeedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(Bulletpitch, Bulletyaw, 0.0f);
    }

}


