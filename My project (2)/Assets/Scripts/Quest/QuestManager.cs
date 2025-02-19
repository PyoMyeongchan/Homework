using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{

    public GameObject QuestPanel;
    public Button button;


    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            OpenQuestPanel();

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseQuestPanel();

        }

    }

    public void OpenQuestPanel()
    {
        QuestPanel.SetActive(true);
        

       
    }

    public void CloseQuestPanel()
    {
        QuestPanel.SetActive(false);       

    }

}
