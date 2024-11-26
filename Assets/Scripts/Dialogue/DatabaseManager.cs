using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager Instance;
    [SerializeField] string csv_FileName;
      
    Dictionary<int, Dialogue> dialogueDic = new Dictionary<int, Dialogue>();// 번호로 찾고싶은 대사를 찾는다 
      
    public static bool isFinish = false; // 파싱한 데이터를 전부 저장 했는지 여부 
      
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DialogueParser theParser = GetComponent<DialogueParser>();
            Dialogue[] dialogues = theParser.parse(csv_FileName);   
            for(int i=0; i<dialogues.Length; i++)
            {
                dialogueDic.Add(i+1, dialogues[i]);
            }
            isFinish = true;
        }
    }
    public Dialogue[] GetDialogue(int _startNum, int _endNum)
    {
        List<Dialogue> dialogueList = new List<Dialogue>(); 
      
        for(int i=0; i<= _endNum - _startNum; i++)
        {
            dialogueList.Add(dialogueDic[_startNum + i]);
        }
        return dialogueList.ToArray();
    }
}
