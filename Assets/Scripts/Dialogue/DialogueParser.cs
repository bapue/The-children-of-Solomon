using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TMPro;
using UnityEngine;

public class DialogueParser : MonoBehaviour
{
    public TextMeshProUGUI testtextl;

    public Dialogue[] parse(string _CSVFileName)
    {
        // 파싱할 데이터를 임시로 저장할 리스트 
        List<Dialogue> dialogueList = new List<Dialogue>(); //대사 리스트 생성 
        TextAsset scvData = Resources.Load<TextAsset>(_CSVFileName); //csv파일 저장
 
        string[] data = scvData.text.Split(new char[] { '\n' });//csv파일의 대사를 엔터를 기준으로(한 줄씩) 나눔
         
        //대사의 행 만큼 반복
        for(int i=1; i<data.Length;)// 1번째 행에는  안덱스가 들어가서 제외 ex) id, 이름, 대사
        {
            
            string[] row = data[i].Split(new char[] { ',' }); //한 줄의 대사를 콤마를 기준으로 나눔
            
            Dialogue dialogue = new Dialogue();
            
            dialogue.TextID = int.Parse(row[0]);
            dialogue.Name = row[2];
            
            List<string> dialogueNumList = new List<string>();
            List<string> contextList = new List<string>();
            List<string> isHaveSelectList = new List<string>();
            List<string> selectTextList = new List<string>();
            List<string> selectAfterNumList = new List<string>();
            
            
            do
            {
                dialogueNumList.Add(row[1]);
                contextList.Add(row[3]);
                isHaveSelectList.Add(row[4]);
                selectTextList.Add(row[5]);
                selectAfterNumList.Add(row[6]);

                if (++i < data.Length) // i가 미리 증가한 상태에서 비교해준다 dataLentg보다 작다면
                {
                    row = data[i].Split(new char[] { ',' }); 
                }
                else
                {
                    break;
                }

            } while (row[0].ToString() == ""); // 최초 1회 조건 비교 없이 한 차례 실행시키고 조건문을 비교
            // row 0번째 줄에는 ID가 들어가 있고 Tostring으로 빈 공간인지 비교해줌
            
            
            dialogue.Text = contextList.ToArray();
            dialogue.IsHaveSelect = isHaveSelectList.ToArray();
            dialogue.DialogueNum = dialogueNumList.ToArray();
            dialogue.SelectText = selectTextList.ToArray();
            dialogue.SelectAfterNum = selectAfterNumList.ToArray();
            
            dialogueList.Add(dialogue);
            GameObject obj = GameObject.Find("DialgoueManager");
            obj.GetComponent<InteractionEvent>().lineY = dialogueList.Count;
            
            
        }
        return dialogueList.ToArray();//리스트를 반환 타입인 배열로 
    }
    
    
}
