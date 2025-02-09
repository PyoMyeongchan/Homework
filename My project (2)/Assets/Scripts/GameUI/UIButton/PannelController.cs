using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class PannelController : MonoBehaviour
{
    public  GameObject Main;
    public  GameObject Arrow;
    public  GameObject Setting;
    public  GameObject Score;

    

    void Start()
    {
        Main.SetActive(true);
        Arrow.SetActive(false);
        Setting.SetActive(false);
        Score.SetActive(false);
    }

   public  void startGame()
    {
        Main.SetActive(false);
        Arrow.SetActive(false);
        Setting.SetActive(false);
        Score.SetActive(true);

    }

    public  void Arrowpanel()
    {
        Main.SetActive(false);
        Arrow.SetActive(true);
        Setting.SetActive(false);
        Score.SetActive(false);

    }
    public  void SettingPanel()
    {   Main.SetActive(false);
        Arrow.SetActive(false);
        Setting.SetActive(true);
        Score.SetActive(false);
    }



}
