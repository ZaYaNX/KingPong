using UnityEngine;
using System.Collections;
public class PlayerPaddleController : MonoBehaviour {
	public int Speed = 10;
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * Speed,0,0);
		this.transform.Translate(movement * Time.deltaTime);
	}
}