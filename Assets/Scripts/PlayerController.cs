using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb2D;

    [SerializeField]
    BoxCollider2D groundCollider;

    float speed = 4.0f;
    float jumpSpeed = 1.0f;
    int maxspeed = 2;
    bool isGrounded;



    void Update()
    {

        if (Input.GetKey("a"))
        {
            rb2D.AddForce(transform.right * speed * -1);
        }
        if (Input.GetKey("d"))
        {
            rb2D.AddForce(transform.right * speed);
        }
        if (Input.GetKey("space"))
        {
            if (isGrounded)
            {
                rb2D.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            isGrounded = true;
        }
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
