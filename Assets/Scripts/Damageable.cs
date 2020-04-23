using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int maxHealth;
    public int health;
    public void takeDamage(int dmgValue)
    {
        health -= dmgValue;
    }
}
