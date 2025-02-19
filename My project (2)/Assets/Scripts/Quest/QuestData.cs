using JetBrains.Annotations;
using System;
using UnityEngine;


[CreateAssetMenu(fileName = "QuestData", menuName ="Quest/Quest")]
public class QuestData : ScriptableObject
{
    
    [Header("퀘스트 정보")]
    public string Tutorial;
    public string GetCoin;
    [TextArea] public string QuestExplain;

    public bool clear;
    public bool 진행중;

}

[Serializable]
[CreateAssetMenu(fileName = "QuestData", menuName = "Quest/Requirment")]

public class Requirment : ScriptableObject
{
    public int coins;

}


[Serializable]
[CreateAssetMenu(fileName = "QuestData", menuName = "Quest/Reward")]
public class Reward : ScriptableObject
{
    public string NextStage;


}

