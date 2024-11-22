using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action<float> OnHealthChanged;
    public event Action<float> OnMentalChanged;
    
    public event Action OnDeath;

    [SerializeField]
    private float currentHealth;
    [SerializeField]
    public float maxHealth { get; private set; } = 100;
    
    
    [SerializeField]
    private float currentMental = 100;
    public float maxMental { get; private set; } = 100;

    
    public float HP
    {
        get { return currentHealth; }

        private set
        {
            currentHealth = Mathf.Clamp(value, 0, maxHealth);
        }
    }
    
    public float MP
    {
        get { return currentMental; }

        private set
        {
            currentMental = Mathf.Clamp(value, 0, maxMental);
        }
    }

    
    
    private void Awake()
    {
        currentHealth = maxHealth;
        currentMental = maxMental;
    }

    public void TakeHealthDamage(float amount)
    {
        currentHealth -= amount;

        OnHealthChanged?.Invoke(currentHealth);
        if (currentHealth <= 0)
            OnDeath?.Invoke();
    }

    public void TakeMentalDamage(float amount)
    {
        currentMental -= amount;

        OnMentalChanged?.Invoke(currentMental);
        if (currentMental <= 0)
            OnDeath?.Invoke();
    }
    
    public void HealthHeal(float amount)
    {
        currentHealth += amount;
        OnHealthChanged?.Invoke(currentHealth);
    }
    
    public void MentalHeal(float amount)
    {
        currentMental += amount;
        OnMentalChanged?.Invoke(currentMental);
    }
    
}