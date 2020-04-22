﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public bool isAutomatic;
    public float coolDown;
    private float nextFire;
    public int manaCost = 0;
    public PlayerScript player;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) || isAutomatic && Input.GetMouseButton(0))
        {
            if (player.mana >= manaCost)
            {
                if (Time.time >= nextFire)
                {
                    fire();
                    player.mana -= manaCost;
                    nextFire = Time.time + coolDown;
                }
            }
        }
    }

    void fire()
    {
        Instantiate<GameObject>(projectile, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z));
    }
}
