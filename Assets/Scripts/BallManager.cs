using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallManager : MonoBehaviour
{

    private Vector3 v = new Vector3(5.0f, 0.0f, 5.0f);
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
        if (collision.collider.name == "Player" || collision.collider.name == "Player2")
            v.x = -v.x;

        else if (collision.collider.name == "Wall_1" || collision.collider.name == "Wall_2")
            v.z = -v.z;
    }

}
