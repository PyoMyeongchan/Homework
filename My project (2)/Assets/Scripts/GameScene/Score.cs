using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text text;
    int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetText();
    }

    public void GetScore()
    {
        score += 1;
    
    }

    public void SetText()
    { 
        text.text = $" Quest - Coin : {score} / 4";

    }
}
