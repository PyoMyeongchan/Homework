using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ButtonScript : MonoBehaviour
{
    public Button StartButton;
    public Button ArrowButton;
    public Button SettingButton;    
    public Button ExitButton;

    public GameObject pannel;

    public void Start()
    {   StartButton = GameObject.Find("StartButton").GetComponent<Button>();
        ArrowButton = GameObject.Find("ArrowButton").GetComponent<Button>();
        SettingButton = GameObject.Find("SettingButton").GetComponent<Button>();
        ExitButton = GameObject.Find("ExitButton").GetComponent<Button>();



        StartButton.onClick.AddListener(StartGame);
        ArrowButton.onClick.AddListener(Arrowpanel);
        SettingButton.onClick.AddListener(SettingPanel);
        ExitButton.onClick.AddListener(exit);
    }
    

           

    public void StartGame()
    {
        pannel.GetComponent<PannelController>().startGame();
    }

    public void Arrowpanel()
    {
        pannel.GetComponent<PannelController>().Arrowpanel();

    }
    public void SettingPanel()
    {
        pannel.GetComponent<PannelController>().SettingPanel();
    }
       

    public void exit()
    {
        Application.Quit();
    }
}
