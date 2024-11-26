using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    [SerializeField]
    public DialogueEvent dialogue;
    
    public int lineY;
    
    public Dialogue[] GetDialgoues()
    {
        dialogue.dialogues = DatabaseManager.Instance.GetDialogue(1, lineY);
        return dialogue.dialogues;
    }
    
    public int GetTextIDLength()
    {
        return dialogue.dialogues.Length;
    }
}
