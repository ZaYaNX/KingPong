using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerPaddleController : NetworkBehaviour {
	public float Speed = 0.5f;
	Rigidbody body;
    Vector3 movement;
    [SerializeField]
    Camera camera;

	
	void Start () 
	{
		body = gameObject.GetComponent<Rigidbody> ();
	}
	
	void Update () 
	{
		Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * Speed,0,0);
        body.velocity = movement;
	}

    public override void OnStartLocalPlayer()
    {
        camera.gameObject.SetActive(true);
    }
}