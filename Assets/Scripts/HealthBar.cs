using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private Slider _healthSlider;
    [SerializeField]
    private Slider _mentalSlider;

    private Health health;
    
    

    private void OnEnable()
    {
        health.OnHealthChanged += UpdateHealthBar;
        health.OnMentalChanged += UpdateMentalBar;
        health.OnDeath += HandleDeath;
        
    }

    private void OnDisable()
    {
        health.OnHealthChanged -= UpdateHealthBar;
        health.OnMentalChanged -= UpdateMentalBar;
        health.OnDeath -= HandleDeath;
    }

    private void Awake()
    {
        health = GetComponent<Health>();
    }
    
    private void Start()
    {
        _healthSlider.maxValue = health.maxHealth;
        _healthSlider.value = health.HP;
        
        _mentalSlider.maxValue = health.maxMental;
        _mentalSlider.value = health.MP;
    }

    private void UpdateHealthBar(float currentHealth)
    {
        _healthSlider.value = currentHealth;
    }
    
    private void UpdateMentalBar(float currentMental)
    {
        _mentalSlider.value = currentMental;
    }

    private void HandleDeath()
    {
        Debug.Log("죽었습니다.");
    }
}