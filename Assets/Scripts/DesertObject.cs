using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertObject : MonoBehaviour
{
    private Movement movement;
    public float destroyDistance;


    // Start is called before the first frame update
    void Start()
    {
        movement = FindObjectOfType<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= destroyDistance)
        {
            Destroy(gameObject);
        }

        // magic number seems to have to do with size of the scrolling texture? i'm not sure
        // i'm not really even sure it's the right speed, but it looks like it
        transform.position += transform.forward * movement.speed * 10 * Time.deltaTime;
    }
}
