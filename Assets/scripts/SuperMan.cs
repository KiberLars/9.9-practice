using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(-11, 0, 0));
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-1000, 0, 0));
    }
}
