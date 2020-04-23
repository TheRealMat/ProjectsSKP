using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{



    public int maxMana;

    public int mana;

    public int healthRegenValue;
    public int manaRegenValue;

    public float healthRegenTime;
    public float manaRegenTime;

    public HealthBar healthBar;
    public HealthBar manaBar;
    public Damageable damageable;


    private float nextHealth;
    private float nextMana;

    private void Start()
    {
        healthBar.SetMaxHealth(damageable.maxHealth);
        manaBar.SetMaxHealth(maxMana);
    }

    void Update()
    {

        if (damageable.health < damageable.maxHealth)
        {
            if (Time.time >= nextHealth)
            {
                damageable.health += healthRegenValue;
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

        healthBar.SetHealth(damageable.health);
        manaBar.SetHealth(mana);





    }
}
