using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float speed = 1f;
    int direction = -1;
    void Update () {
        if (speed < 0)
        {
            speed = Mathf.Abs(speed);
        }
            transform.Translate(-Vector3.right * (direction * speed));
                if (transform.position.x >= 4)
                {
                    direction = 1;
                }

                if (transform.position.x <= -4)
                {
                    direction = -1;
                }
                
        }
}
