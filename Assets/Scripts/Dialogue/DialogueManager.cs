using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class DialogueManager : MonoBehaviour
{
    InteractionEvent interactionEvent;

    public TMP_Text storyTeller;
    
    
    public TMP_Text selectText_1;
    public TMP_Text selectText_2;


    private int randomID;
    void Awake()
    {
        interactionEvent = GetComponent<InteractionEvent>();
    }

    void Start()
    {
        interactionEvent.GetDialgoues();
    }




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomID();
        }
    }

    void RandomID()
    {
        storyTeller.text = "";
        int length = interactionEvent.GetTextIDLength();
        randomID = UnityEngine.Random.Range(0, length);
        
        PrintText();
    }

    //await UniTask.Delay(2000);  // 2초 대기
    //await UniTask.Delay(3000);  // 3초 대기
    //await UniTask.WhenAll(Task1(), Task2()); // Task1과 Task2가 끝날 때까지 대기
    //await UniTask.WaitUntil(()=> count ==  7); // count가 7이 될 때까지 대기  (조건)
    
    private void PrintText(int count = 0)
    {

        if (count < interactionEvent.dialogue.dialogues[randomID].DialogueNum.Length) //재귀함수임 현재 다이얼로그 최대 개수가 끝날때까지 반복임
        {
            // for (int i = 0; i < interactionEvent.dialogue.dialogues[randomID].DialogueNum.Length; i++)
            // {
            storyTeller.text += interactionEvent.dialogue.dialogues[randomID].Text[count]; // 먼저 텍스트 출력


            // #region 선택지 출력
            //
            // if (interactionEvent.dialogue.dialogues[randomID].IsHaveSelect[count] == "TRUE") // 만약 선택지가 있다면
            // {
            //     //선택지의 개수 확인하는 법
            //     //선택지의 개수가 2개일 때
            //
            //     for (int j = 0;
            //          j < interactionEvent.dialogue.dialogues[randomID].SelectText.Length;
            //          j++) //선택지 예외처리이긴 한데 선택지가 3개 이상일 경우 예외처리도 필요 함
            //     {
            //         if (interactionEvent.dialogue.dialogues[randomID].SelectText[j] == "")
            //         {
            //             continue;
            //         }
            //         else
            //         {
            //             selectText_1.text =
            //                 interactionEvent.dialogue.dialogues[randomID].SelectText[j]; // 선택지 1번째 텍스트 출력
            //             selectText_2.text =
            //                 interactionEvent.dialogue.dialogues[randomID].SelectText[j + 1]; // 선택지 2번째 텍스트 출력
            //
            //             //TODO: 선택지가 3개 이상일 때 예외처리
            //             break;
            //         }
            //     }
            // }
            // else
            // {
            //     selectText_1.text = "";
            //     selectText_2.text = "";
            // }

            //#endregion

            PrintText(count + 1); 
        }
        //}
        
        
        //선택지 선택시 count를 해당 번호로 변경해줘야 함 버튼?
    }
}