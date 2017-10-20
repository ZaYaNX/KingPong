using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour 
{
    [SerializeField] GameObject baseCanvas;
    [SerializeField] GameObject hostCanvas;
    [SerializeField] GameObject clientCanvas;
    Menu menu;
    [SerializeField] Text inputFieldText;
    [SerializeField] Text nameOfServer;

    void Start () 
	{
        menu = gameObject.GetComponent<Menu>();
	}
	
    public string GetServerName()
    {
        return inputFieldText.text;
    }

    public void SetserverName(string name)
    {
        nameOfServer.text = name;
    }

    public void CreateGame()
    {
        baseCanvas.SetActive(false);
        hostCanvas.SetActive(true);
    }

    public void JoinGame()
    {
        baseCanvas.SetActive(false);
        clientCanvas.SetActive(true);
        menu.JoinServer();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
