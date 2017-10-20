using UnityEngine;
using System.Collections;
public class PlayerPaddleController : MonoBehaviour {
	public int Speed = 10;
	Rigidbody body;
	// Use this for initialization
	void Start () 
	{
		body = gameObject.GetComponent<Rigidbody> ();
	}
	// Update is called once per frame
	void Update () 
	{
		Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * Speed,0,0);
		body.velocity = movement;
	}

	void FixedUpdate()
	{
		
	}
}