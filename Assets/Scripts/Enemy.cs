using System;
using UnityEngine;

[Serializable]
public class Enemy
{
    //Way 1 Create from Inspector
    [SerializeField]
    public string Name;

    public int Health;
    public int MaxHealth;
    public int Damage;
    public Player Player;
    public Sprite Sprite;
    
    public bool isDead = false;
    //Way 2 Create from Script 
    public Enemy(string name, int health, Player player)
    {
        Player = player;
        Name = name;
        Health = health;
    }
    
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Die();
        }
    }
    
    public void Attack()
    {
        
    }
    
    public void Die()
    {
        Debug.Log(Name + " is dead");
    }
    
    
    
    
}
