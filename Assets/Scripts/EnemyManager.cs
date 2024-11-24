using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{

    private int ranNum;
    public List<int> randomNumbers = new List<int>();

    
    
    public Image enemyProfile;
    public TMP_Text enemyName;
    public TMP_Text enemyHealth;
    public TMP_Text enemyDamage;
    
    //랜덤 적일때의 데이터
    [SerializeField]
    private EnemyData enemyData;

    //적 데이터 리스트
    [SerializeField]
    private List<EnemyData> enemyDatas;

    [SerializeField]
    private Health health;

    public void InitUI()
    {
        enemyData = enemyDatas[ranNum];
        //TODO: Making random enemy initialization to UI
        enemyProfile.sprite = enemyData.ProfileImage;
        enemyName.text = enemyData.EnemyName;
        enemyHealth.text = enemyData.Hp.ToString();
        enemyDamage.text = enemyData.Damage.ToString();
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Random Number: " + ranNum);
    
            UniqueRandom();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            EnemyAttack();
        }
    }


    private void Start()
    {
        randomNumbers = Enumerable.Range(0, enemyDatas.Count).ToList();
    }
    
    

    public void EnemyAttack()
    {
        health.TakeHealthDamage(enemyData.Damage);
    }



    //중복없는 난수 생성
    //TODO: 플레이어가 죽고나서 다시 시작할때 리스트를 초기화해줘야하는 작업 필요
    public void UniqueRandom()
    {
        ranNum = Random.Range(0, randomNumbers.Count);
        Debug.Log(randomNumbers[ranNum]);
        randomNumbers.RemoveAt(ranNum);
        InitUI();
    }
    
    
}
