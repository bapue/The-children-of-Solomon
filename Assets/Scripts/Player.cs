using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    
    [Header("생명 및 돈 변수")]
    public int money { get; set; } = 0;
    
    [Header("능력치 관련 변수")]
    public int strength = 10; //근력
    public int intelligence = 10; //지능
    public int wisdom = 10; //지혜
    public int dexterity = 10; //재주
    public int charisma = 10; //매력
    public int luck = 10; //운

    
    [Header("레벨 업 관련 변수")]
    public int level = 1;
    public int exp = 0;
    public int maxExp = 100;
    public int skillPoint = 0;
    
    public void InitSetting()
    {
        money = 0;
    }

    public void AddMoney(int amount)
    {
        money += amount;
    }
    
    public void RemoveMoney(int amount)
    {
        money -= amount;
    }

    public void Die()
    {
        //TODO: End game and Init First Setting
        InitSetting();
    }
    

}