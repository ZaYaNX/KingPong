using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BallManager : NetworkBehaviour
{

    private Vector3 vitesse = new Vector3(2.0f, 0.0f, 2.0f);
    Rigidbody body;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        body.velocity = vitesse;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            vitesse.z = -1 * vitesse.z;
        
        else if (collision.collider.name == "Wall_1" || collision.collider.name == "Wall_2")
            vitesse.x = -1 * vitesse.x;
    }

}
