using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [Tooltip("Primary Key")]
    public int TextID;
    [Tooltip("현재 ID의 대사 번호")]
    public string[] DialogueNum;
    
    [Tooltip("이름")]
    public string Name;
    
    [Tooltip("대사")]
    public string[] Text;
    
    [Tooltip("선택지가 있는지")]
    public string[] IsHaveSelect;
    
    [Tooltip("선택지 대사")]
    public string[] SelectText;
    
    [Tooltip("현재 대사 이후의 대사 번호")]
    public string[] SelectAfterNum;
}

[System.Serializable]
public class DialogueEvent
{
    public string name; //이벤트의 이름

    public Vector2 line; // 대사 라인
    public Dialogue[] dialogues;
}