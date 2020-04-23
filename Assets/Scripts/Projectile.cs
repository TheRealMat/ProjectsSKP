using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float velocity;
    public float killTime;

    private float counter;
    Rigidbody rigidBody;
    Collider thisCollider;
    public List<ParticleSystem> pSystems;
    public LayerMask groundMask;
    public float groundDistance = 0.4f;
    bool isGrounded;
    public int damage;
    private void Start()
    {
        rigidBody = this.transform.GetComponent<Rigidbody>();
        thisCollider = transform.GetComponent<SphereCollider>();
    }



    private void Update()
    {
        rigidBody.velocity = transform.forward * velocity * Time.deltaTime;



        //// speeds it up over time
        //rigidBody.AddForce(transform.forward * velocity * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        counter++;

        if (counter >= killTime)
        {
            Destroy(this.gameObject);
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        foreach (ParticleSystem p in pSystems)
        {
            p.Stop();
            p.transform.parent = null;
            Destroy(p.gameObject, 5f); // if particles live for at most 5 secs. it doesn't seem possible to get the actual lifetime of particles
        }
        Destroy(this.gameObject);
        if (other.GetComponent<Damageable>() != null)
        {
            // can i get this from the if statement so i don't have to look it up twice?
            Damageable hitDamageable = other.GetComponent<Damageable>();
            hitDamageable.takeDamage(damage);

        }
    }

}
