using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int maxHealth;
    public int maxMana;

    public int health;
    public int mana;

    public int healthRegenValue;
    public int manaRegenValue;

    public int healthRegenTime;
    public int manaRegenTime;

    public HealthBar healthBar;
    public HealthBar manaBar;


    private float nextHealth;
    private float nextMana;

    void Update()
    {

        if (health < maxHealth)
        {
            if (Time.time >= nextHealth)
            {
                health += healthRegenValue;
                nextHealth = Time.time + manaRegenTime;
            }
        }

        if (mana < maxMana)
        {
            if (Time.time >= nextMana)
            {
                mana += manaRegenValue;
                nextMana = Time.time + manaRegenTime;
            }
        }

        health = Mathf.Clamp(health, 0, maxHealth);
        mana = Mathf.Clamp(health, 0, maxMana);


    }
}
