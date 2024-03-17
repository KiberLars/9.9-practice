using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{

    public float TimeToExplosion;
    public float Power;
    public float Radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeToExplosion -= Time.deltaTime;

        if (TimeToExplosion < 0 )
        {
            Boom();
        }
    }

    void Boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();

        foreach ( Rigidbody b in blocks )
        {
            float distance = Vector3.Distance(transform.position, b.transform.position);
            if (distance < Radius)
            {
                Vector3 direction = b.transform.position - transform.position;

                b.AddForce(direction.normalized * Power * (Radius - distance), ForceMode.Impulse);
            }
        }

        TimeToExplosion = 3;
    }
}
