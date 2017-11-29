using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour

{

    private void OnCollisionEnter(Collision collision)
    {
        BallManager ball = collision.gameObject.GetComponent<BallManager>();
        if (ball != null)
        {
            ball.transform.position = new Vector3(0.0f, 0.2f, 0.0f);
        }
    }
}
