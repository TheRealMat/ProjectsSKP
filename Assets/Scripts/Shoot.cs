﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public bool isAutomatic;
    public float coolDown;
    private float nextFire;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextFire)
        {
            nextFire = Time.time + coolDown;
            if (Input.GetMouseButtonDown(0) || isAutomatic && Input.GetMouseButton(0))
            {
                fire();
            }
        }
    }

    void fire()
    {
        Instantiate<GameObject>(projectile, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z));
    }
}
