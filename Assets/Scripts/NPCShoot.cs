using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCShoot : MonoBehaviour
{
    public GameObject projectile;
    public float coolDown;
    private float nextFire;
    private float nextLineOfSightCheck;
    private float LineOfSightcoolDown = 0.2f;
    public Transform target;
    public LayerMask groundMask;

    // Update is called once per frame
    void Update()
    {

        if (CanFire() && CanSeeTarget())
        {
            fire();
            nextLineOfSightCheck = Time.time + LineOfSightcoolDown;
            nextFire = Time.time + coolDown;
        }

    }

    // Checks if npc can see target
    bool CanSeeTarget()
    {
        // Only runs the expensive check if the fast time check passes
        return Time.time >= nextLineOfSightCheck && !Physics.Linecast(transform.position, target.position, groundMask);
    }

    bool CanFire()
    {
        return Time.time >= nextFire;
    }

    void fire()
    {
        transform.LookAt(target);
        GameObject shotProjectile = Instantiate<GameObject>(projectile, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z));
        Physics.IgnoreCollision(shotProjectile.GetComponent<Collider>(), transform.parent.GetComponent<Collider>());

    }
}
