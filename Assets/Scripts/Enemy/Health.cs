using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private float currentHealth;
    public float startingHealth;

    public GameObject healthBar;
    public Slider healthBarSlider;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    //activate healthbar UI and set it to percentage of health
    public void takeDamage(float damage)
    {
        healthBar.SetActive(true);
        currentHealth -= damage;
        healthBarSlider.value = (currentHealth/startingHealth);
        CheckDeath();
    }

    public void HealCharacter(float heal)
    {
        currentHealth += heal;
        CheckOverheal();
    }
    private void CheckOverheal()
    {
        if (currentHealth > startingHealth)
        {
            currentHealth = startingHealth;
        }
    }

    private void CheckDeath()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
