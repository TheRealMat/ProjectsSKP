using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float scrollSpeed;

    public List<Renderer> scrollingRenderers = new List<Renderer>();


    public float speed = 0.0f; //current speed
    private float desiredSpeed;
    private float pos; //total texture offset
    private float acceleration = 0.001f;


    public float horizontalSpeed = 1; // speed in meters per second
    public float driftSpeed = 1; // speed in meters per second


    void Start()
    {
        // get references to scrolling textures
        GameObject[] scrollingObjects = GameObject.FindGameObjectsWithTag("ScrollingTexture");
        foreach (GameObject gameObject in scrollingObjects)
        {
            scrollingRenderers.Add(gameObject.GetComponent<Renderer>());
        }


        // start moving
        desiredSpeed = 5;
    }

    void Update()
    {
        // texture scrolling

        speed += (desiredSpeed - speed) * acceleration;

        //add current speed to the position
        pos += speed * Time.deltaTime;

        Vector2 offset = new Vector2(0, pos);
        foreach (Renderer renderer in scrollingRenderers)
        {
            renderer.material.SetTextureOffset("_MainTex", offset);
        }






        // horizontal movement

        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis("Horizontal");

        transform.position += moveDir * -horizontalSpeed * speed * Time.deltaTime;

        // sideways drift
        transform.position += transform.right * driftSpeed * speed * Time.deltaTime;




        // checks if out of bounds
        if (transform.position.x > 5 || transform.position.x < -5)
        {
            desiredSpeed = 0;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
