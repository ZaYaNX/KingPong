using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerPaddleController : NetworkBehaviour {
	public float Speed = 0.5f;
	Rigidbody body;
    Vector3 movement;
    [SerializeField] [SyncVar] int playerID = -1;
    [SerializeField]
    Camera camera;

	public int PlayerID
    {
        get
        {
            return playerID;
        }
        set
        {
            playerID = value;
        }
    }
	void Start () 
	{
		body = gameObject.GetComponent<Rigidbody> ();
	}
	[ClientCallback]
	void Update () 
	{
        if (!isLocalPlayer)
            return;
        
		Vector3 movement = new Vector3(-Input.GetAxis("Horizontal") * Speed,0,0);
        body.velocity = movement;
	}

    public override void OnStartLocalPlayer()
    {
        camera.gameObject.SetActive(true);
    }
}