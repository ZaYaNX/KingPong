using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallManager : MonoBehaviour
{

    private Vector3 v = new Vector3(2.0f, 0.0f, 2.0f);
    Rigidbody body;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        body.velocity = v;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            v.z = -1 * v.z;
        
        else if (collision.collider.name == "Wall_1" || collision.collider.name == "Wall_2")
            v.x = -1 * v.x;
    }

}
