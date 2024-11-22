using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{

    private int ranNum;
    
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
    
            RollEnemy();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            EnemyAttack();
        }
    }


    private void Start()
    {

    }
    
    
    //적이 나타날때 랜덤과 동시에 UI 초기화
    public void RollEnemy()
    {
        ranNum = Random.Range(0, 3);
        InitUI();
    }

    public void EnemyAttack()
    {
        health.TakeHealthDamage(enemyData.Damage);
    }
    
    
    //죽었는지 체크하여 리스트에서 제거
    public void CheckEnemyDead()
    {
        
        
    }
}
