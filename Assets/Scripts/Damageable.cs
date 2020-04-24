using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int maxHealth;
    public int health;
    public bool getsDestroyed;
    public void takeDamage(int dmgValue)
    {
        health -= dmgValue;
        if (health <= 0 && getsDestroyed == true)
        {
            Destroy(gameObject);
        }
    }
}
