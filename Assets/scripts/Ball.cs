using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float startTime = 1.5f;
    bool isBit = false;

    void Update()
    {
        startTime -= Time.deltaTime;
        if (startTime < 0 && isBit == false)
        {
            if (GetComponent<Rigidbody>() != null)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(50, 0, 0));
            }
            isBit = true;
        }
    }
}
