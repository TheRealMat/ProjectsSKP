using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCShoot : MonoBehaviour
{
    public GameObject projectile;
    public float coolDown;
    private float nextFire;
    public Transform target;
    public LayerMask groundMask;

    // Update is called once per frame
    void Update()
    {
        // don't do this every frame
        if (!Physics.Linecast(transform.position, target.position, groundMask))
        {
            if (Time.time >= nextFire)
            {
                fire();
                nextFire = Time.time + coolDown;
            }
        }

    }

    void fire()
    {
        transform.LookAt(target);
        Instantiate<GameObject>(projectile, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z));

    }
}
