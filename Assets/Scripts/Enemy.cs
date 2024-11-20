using System;
using UnityEngine;

[Serializable]
public class Enemy
{
    [SerializeField]
    public string Name;

    public int Health;
    public int MaxHealth;
    public int Damage;
    
    
    
    
    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }
    
}
