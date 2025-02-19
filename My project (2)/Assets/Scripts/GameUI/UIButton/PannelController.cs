using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PannelController : MonoBehaviour
{
    public  GameObject Main;
    public  GameObject Arrow;
    public  GameObject Setting;
    

    

    void Start()
    {
        Main.SetActive(true);
        Arrow.SetActive(false);
        Setting.SetActive(false);
        
    }

   public  void startGame()
    {
        SceneManager.LoadScene("GameScene");
        

    }

    public  void Arrowpanel()
    {
        Main.SetActive(false);
        Arrow.SetActive(true);
        Setting.SetActive(false);
       

    }
    public  void SettingPanel()
    {   Main.SetActive(false);
        Arrow.SetActive(false);
        Setting.SetActive(true);
        
    }

    public void back()
    {
        Main.SetActive(true);
        Arrow.SetActive(false);
        Setting.SetActive(false);        


    }



}
