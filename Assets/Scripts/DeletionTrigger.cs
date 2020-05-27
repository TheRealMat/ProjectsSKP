using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletionTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Doodad")) {
            Destroy(other.gameObject);
        }
    }
}
