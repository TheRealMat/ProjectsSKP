using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float velocity;
    public float killTime;

    private float counter;
    Rigidbody rigidBody;
    public List<ParticleSystem> pSystems;
    public LayerMask groundMask;
    public float groundDistance = 0.4f;
    bool isGrounded;
    private void Start()
    {
        rigidBody = this.transform.GetComponent<Rigidbody>();
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

        isGrounded = Physics.CheckSphere(transform.position, groundDistance, groundMask);
        if (isGrounded)
        {
            foreach (ParticleSystem p in pSystems)
            {
                p.Stop();
                p.transform.parent = null;
                Destroy(p.gameObject, 5f); // if particles live for at most 5 secs. it doesn't seem possible to get the actual lifetime of particles
            }
            Destroy(this.gameObject);
        }
    }
}
