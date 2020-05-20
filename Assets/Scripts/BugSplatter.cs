using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugSplatter : MonoBehaviour
{
    public int minutesToSplatter;
    public bool bugSplatted;


    private void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    public void Splat()
    {
        bugSplatted = true;

        // play a sound

        GetComponent<SpriteRenderer>().enabled = true;
    }
}
