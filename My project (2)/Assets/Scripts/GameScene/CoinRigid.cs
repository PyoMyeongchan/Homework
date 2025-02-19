using UnityEngine;
using UnityEngine.UI;

public class CoinRigid : MonoBehaviour
{
    public GameObject portal;

    public Text text;

    public Text sucess;
    
    static int count = 1;

    private void OnTriggerEnter(Collider coin)
    {
        if (coin.gameObject.tag == "OpenQuest")
        {

            Destroy(coin.gameObject);
            
        }

        else if (coin.gameObject.tag == "Item")
        {
            Destroy(coin.gameObject);
            Quest();
            count+=1;

        }

        else if (coin.gameObject.tag == "OpenPortal")
        {
            Destroy(coin.gameObject);


            portal.SetActive(true);

            QuestSuccess();
        }
        else if (coin.gameObject.tag == "portal")
        {
            Success();
        }
        

    }
    

    void Quest()
    {

        Instantiate(text);
        text.text = $"Quest - Coin : {count} / 3";
                

    }

    void QuestSuccess()
    {

        Destroy(text,2);
    
    
    }

    void Success()
    {
        Instantiate(sucess);
        sucess.text = "Clear";    
    }
        

}
