
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
public class Pause : NetworkBehaviour

{
    [SerializeField]
    GameObject PauseUI;
    private bool Paused = false;
    void Start()
    {
        PauseUI.SetActive(false);
    }

    [ServerCallback]
    void PauseCallBack()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            Paused = !Paused;
        }
        if (Paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
        if (!Paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }

    void Update()
    {
        PauseCallBack();
    }

    public void Resume()
    {
        Paused = false;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Lobby");
        Paused = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}