using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float currentHealth;
    public float startingHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    public void takeDamage(float damage)
    {
        currentHealth -= damage;
        print(currentHealth);
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
