using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Menu : NetworkDiscovery
{

    NetworkManager networkManager;
    CanvasManager canvasManager;
    string serverName;
    string ipAdress = null;

    void Start()
    {
        networkManager = GameObject.Find("NetworkManager").GetComponent<NetworkManager>();
        canvasManager = gameObject.GetComponent<CanvasManager>();
    }

    public void CreateServer()
    {
        Initialize();
        serverName = canvasManager.GetServerName();
        broadcastData = serverName;
        StartAsServer();
        networkManager.StartHost();
    }

    public void JoinServer()
    {
        Initialize();
        StartAsClient();
    }

    public override void OnReceivedBroadcast(string fromAddress, string data)
    {
        base.OnReceivedBroadcast(fromAddress, data);
        ipAdress = fromAddress;
        canvasManager.SetserverName(data);
    }

    public void Connect()
    {
        networkManager.networkAddress = ipAdress;
        networkManager.StartClient();
    }
}
