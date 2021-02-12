using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    float currentHealth;
    [SerializeField] private float maxHealth = 100;
    
    private void Start()
    {
        currentHealth = maxHealth;        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;        
        if(currentHealth <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        Destroy(gameObject);
    }

    public float getHealth()
    {
        return currentHealth;
    }
}
