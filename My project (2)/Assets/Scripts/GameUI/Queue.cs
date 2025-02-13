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
        stringQueue.Enqueue("�������! ArrowShot�� �������ּż� �����մϴ�!");
        stringQueue.Enqueue("���� Ʃ�丮���� �˷��帱�Կ�!");
        stringQueue.Enqueue("�տ� �ִ� ���Ϳ� ȭ���� 3�� ���߰� �Ǹ� �������� �������ſ���!");
        stringQueue.Enqueue("�������� ȭ���� 1�� ���߸� ���� �� �ִ�ϴ�!");
        stringQueue.Enqueue("�׷� �ϴ� 3���� ������ �������ֽǷ���? �Ƹ� �پ��� �������� �����ٵ� ���� ���� 3���� �ʿ��ؿ�!");

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
            
                name.text = "����";
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
