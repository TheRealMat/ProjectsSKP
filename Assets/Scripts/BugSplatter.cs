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
        GameObject.FindObjectOfType<GameEvents>().onMinuteChanged += Splat;

    }

    public void Splat(int minute)
    {
        if (minute >= minutesToSplatter)
        {
            bugSplatted = true;

            // play a sound

            GetComponent<SpriteRenderer>().enabled = true;

            GameObject.FindObjectOfType<GameEvents>().onMinuteChanged -= Splat;
        }
    }
}
