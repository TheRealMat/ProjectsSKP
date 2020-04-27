using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool needsKey;
    public GameObject key;
    public float openDistance;

    public bool doorOpen;
    private Animator animator;
    bool testHasKey = false;

    private void Start()
    {
        animator = GetComponent<Animator>(); 
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (needsKey == true)
            {
                if (doorOpen == false && testHasKey == true)
                {
                    doorOpen = true;
                    DoorControl("Open");
                }
                else if (doorOpen == false && testHasKey == false)
                {
                    DoorControl("Locked");
                }
            }

            else
            {
                if (doorOpen == false)
                {
                    doorOpen = true;
                    DoorControl("Open");
                }
            }





        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (doorOpen == true)
        {
            doorOpen = false;
            DoorControl("Close");
        }
    }

    private void DoorControl(string trigger)
    {
        animator.SetTrigger(trigger);
    }
}
