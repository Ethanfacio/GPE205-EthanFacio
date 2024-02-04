using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float amount, Pawn source)
    {
        currentHealth -= amount;
        Debug.Log(source.name + "did" + amount + "damage to " + gameObject.name);

        if(currentHealth <= 0)
        {
            Die(source);
        }
    }
    public void ReplenishHealth(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }
    public void Die(Pawn source)
    {
        Debug.Log(source.name + " Destroyed " + gameObject.name);
    }
}
