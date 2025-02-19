using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class Queue : MonoBehaviour
{

    public GameObject gameObject;
    public GameObject elipanel;
    
    public Text text;
  

    public Queue<string> stringQueue = new Queue<string> ();

    public void Start()
    {
        stringQueue.Enqueue("어서오세요! 모험가님!");
        stringQueue.Enqueue("먼저 튜토리얼부터 시작해볼까요?");
        stringQueue.Enqueue("방향키버튼을 눌러 포탈로 들어가주세요");
        stringQueue.Enqueue("포탈이 어디있냐구요?");
        stringQueue.Enqueue("앞에 있는 동전을 다 먹으면 포탈이 생길거에요");
        stringQueue.Enqueue("퀘스트는 위에 뜬 Q를 눌러주시면 볼 수 있어요");
        stringQueue.Enqueue("얼른 이동해보세요!");


    }
     

    public void NextButtonClick()
    {
        gameObject.SetActive(true);

        StartCoroutine("talk");
    }

    public void NameButtonClick()
    { 
        gameObject.SetActive (true);

        StartCoroutine("nametext");
    }
       
    IEnumerator talk()
    {
        for (int i = 0; i < stringQueue.Count; i++)
        {
                
                text.text = stringQueue.Dequeue();
                yield return new WaitForSeconds(15f);
                

        }
        gameObject.SetActive(false);
        elipanel.SetActive(false);
    }

    IEnumerator nametext()
    {
        for (int i = 0; i < stringQueue.Count; i++)
        {
            
                
                yield return new WaitForSeconds(15f);
            
        }
        gameObject.SetActive(false);

    }
   

}
