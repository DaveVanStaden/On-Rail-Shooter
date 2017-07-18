using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardDestroy : MonoBehaviour {

    bool timer = false;
    int i = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            GetComponent<Renderer>().material.color = Color.red;
            timer = true;
        }
    }

    private void Update()
    {
        if(timer == true)
        {
            i = i + 1;
        }
        if (i >= 20)
        {
            GetComponent<Renderer>().material.color = Color.grey;
            timer = false;
            i = 0;
        }
    }

}
