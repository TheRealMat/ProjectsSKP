using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsTrigger : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            // to make sure you don't lose after winning
            if (FindObjectOfType<GameManager>().gameWon == false)
            {
                GameObject.FindObjectOfType<GameEvents>().GameOver();
            }
        }
    }
}
