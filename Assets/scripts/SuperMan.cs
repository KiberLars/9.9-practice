using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMan : MonoBehaviour
{
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(-11, 0, 0));
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-1000, 0, 0));
        }
    }
}
