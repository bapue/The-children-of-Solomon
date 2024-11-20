using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] public List<Enemy> enemies;
    
    public void Setup()
    {

        Debug.Log(enemies[0].Name);
        Debug.Log(enemies[0].Health);
        Debug.Log(enemies[0].MaxHealth);
        
        Debug.Log(enemies[1].Name);
        Debug.Log(enemies[1].Health);
        Debug.Log(enemies[1].MaxHealth);
        
    }


    private void Start()
    {
        Setup();        
    }
}
