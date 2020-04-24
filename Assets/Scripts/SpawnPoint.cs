using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject spawnObject;
    public bool deleteAfterUse;


    private void Start()
    {
        Instantiate(spawnObject);
        if (deleteAfterUse)
        {
            Destroy(gameObject);
        }
    }
}
