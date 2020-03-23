using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length;
    private float startpos;
    public GameObject cam;
    public float parallaxAmount;

    private void Start()
    {
        startpos = transform.position.x;
        // length of sprite
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        float temp = (cam.transform.position.x * (1 - parallaxAmount));
        float dist = (cam.transform.position.x * parallaxAmount);
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        // repeats background
        if (temp > startpos + length)
        {
            startpos += length;
        }
        else if (temp < startpos - length)
        {
            startpos -= length;
        }

    }
}
