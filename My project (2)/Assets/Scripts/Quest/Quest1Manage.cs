using UnityEngine;
using UnityEngine.UI;

public class Quest1Manage : MonoBehaviour
{
    public QuestData QuestData;
    public Text QusetName;
    public Text Questtext;
    public Text Questdescription;
    

    void questname()
    {
        QusetName.text = QuestData.Tutorial;
        Questtext.text = QuestData.GetCoin;
        Questdescription.text = QuestData.QuestExplain;


    }

    // Update is called once per frame
    void Update()
    {
        questname();
    }
}
