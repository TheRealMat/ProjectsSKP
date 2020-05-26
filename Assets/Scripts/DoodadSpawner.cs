using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodadSpawner : MonoBehaviour
{
    public float minRange;
    public float maxRange;
    public float spawnDistance;
    [Range(0.0f, 1.0f)]
    public float spawnChance;
    public float spawnTimeSeconds;
    private float elapsedSeconds;

    public GameObject cactus;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (gameManager.gameStarted == true && gameManager.gameWon == false)
        {
            elapsedSeconds += Time.deltaTime;
            if (elapsedSeconds >= spawnTimeSeconds)
            {
                elapsedSeconds = 0;

                // checks if we want to spawn something
                if (Random.value <= spawnChance)
                {
                    // checks which side of the road to spawn it on
                    if (Random.value <= 0.5)
                    {
                        SpawnObject(cactus, minRange, maxRange, spawnDistance);
                    }
                    else
                    {
                        SpawnObject(cactus, -minRange, -maxRange, spawnDistance);
                    }

                }
            }
        }

    }


    public void SpawnObject(GameObject prefab, float min, float max, float distance)
    {
        Vector3 position = new Vector3(Random.Range(min, max), 0, distance);
        Instantiate(prefab, position, Quaternion.identity);
    }
}
