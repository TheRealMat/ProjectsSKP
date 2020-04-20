using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float velocity;
    public float killTime;

    private float counter;
    Rigidbody rigidBody;

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
    }
}
