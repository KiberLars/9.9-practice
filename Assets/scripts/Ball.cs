using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float startTime = 1.5f;
    bool isBit = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        startTime -= Time.deltaTime;
        if (startTime < 0 && isBit == false)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(50, 0, 0));
            isBit = true;
        }
    }
    private void FixedUpdate()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
    }
}
