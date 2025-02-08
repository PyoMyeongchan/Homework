using System.Collections;
using Unity.Android.Types;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    Image image;
    IEnumerator FadeIn()
    {
        float f = 0;
        while(f<=1)
        {
            f += 0.1f;
            Color ColorAlpha = image.material.color;
            ColorAlpha.a = f;
            image.material.color = ColorAlpha;
            yield return new WaitForSeconds(0.1f);
                }
        

    }

    IEnumerator FadeOut()
    {
        float f = 1;
        while (f > 0)
        {
            f -= 0.1f;
            Color ColorAlpha = image.material.color;
            ColorAlpha.a = f;
            image.material.color = ColorAlpha;
            yield return new WaitForSeconds(0.1f);
        }
    
    
    
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        image.material.color = new Color(1, 1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && image.material.color.a <= 1)
        { StartCoroutine(FadeIn()); }
                
        else if (Input.GetKeyUp(KeyCode.Space) && image.material.color.a > 0)
        { StartCoroutine(FadeOut());

            Invoke("Next", 2f);         
            
        }
                             
        
    }

    void Next()
    {
        SceneManager.LoadScene("GameUI");

    }


}
