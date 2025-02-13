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
    public Image image;
    public Text text;
    public Text name;

    public Queue<string> stringQueue = new Queue<string> ();

    public void Start()
    {
        stringQueue.Enqueue("어서오세요! ArrowShot에 참가해주셔서 감사합니다!");
        stringQueue.Enqueue("먼저 튜토리얼을 알려드릴게요!");
        stringQueue.Enqueue("앞에 있는 몬스터에 화살을 3번 맞추게 되면 아이템을 내놓을거에요!");
        stringQueue.Enqueue("아이템은 화살을 1번 맞추면 얻을 수 있답니다!");
        stringQueue.Enqueue("그럼 일단 3개의 리본을 가져다주실래요? 아마 다양한 아이템이 나올텐데 저는 리본 3개가 필요해요!");

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

    public void imageButtonClick()
    {
        gameObject.SetActive(true);

        StartCoroutine("imageRender");
    }
    IEnumerator talk()
    {
        for (int i = 0; i < stringQueue.Count; i++)
        {
                GetComponent<Image>();
                text.text = stringQueue.Dequeue();
                yield return new WaitForSeconds(5f);
                

        }
        gameObject.SetActive(false);
        elipanel.SetActive(false);
    }

    IEnumerator nametext()
    {
        for (int i = 0; i < stringQueue.Count; i++)
        {
            
                name.text = "엘리";
                yield return new WaitForSeconds(5f);
            
        }
        gameObject.SetActive(false);

    }
    IEnumerator imageRendert()
    {
        for (int i = 0; i < stringQueue.Count; i++)
        {

            GetComponent<Image>();
            yield return new WaitForSeconds(5f);
            
        }
        gameObject.SetActive(false);

    }

}
