using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class PauseManager : MonoBehaviour

{
    [SerializeField]
    GameObject PauseUI;
    private bool Paused = false;
    void Start()
    {
        PauseUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            Paused = !Paused;
        }
        if (Paused)
        {
            PauseUI.SetActive(true);

        }
        if (!Paused)
        {
            PauseUI.SetActive(false);

        }
    }

    public void Reprendre()
    {
        Paused = false;
    }

    public void Disconnect()
    {
        if (Network.isServer)
        {
            NetworkManager.singleton.StopHost();
        }
        else
        {
            NetworkManager.singleton.StopClient();
        }
    }

}   