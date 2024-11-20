using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health { get; set; } = 100;
    public int MaxHealth = 100;

    public int Mental { get; set; } = 100;
    public int MaxMental = 100;

    public int Money { get; set; } = 0;


    public void InitSetting()
    {
        Health = 100;
        MaxHealth = 100;
        Mental = 100;
        MaxMental = 100;
        Money = 0;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            //TODO: Die
        }
    }

    public void HealHealth(int amount)
    {
        Health += amount;
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    public void TakeMental(int damage)
    {
        Mental -= damage;
        if (Mental <= 0)
        {
            Die();
        }
    }
    
    public void HealMental(int amount)
    {
        Mental += amount;
        if (Mental > MaxMental)
        {
            Mental = MaxMental;
        }
    }
    
    public void AddMoney(int amount)
    {
        Money += amount;
    }
    
    public void RemoveMoney(int amount)
    {
        Money -= amount;
    }

    public void Die()
    {
        //TODO: End game and Init First Setting
        InitSetting();
    }
    

}