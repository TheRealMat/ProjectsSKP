using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



[CustomEditor(typeof(CubeExample))]
public class CubeEditor : Editor
{
    void OnSceneGUI()
    {
        CubeExample cubeExample = (CubeExample)target;

        Handles.color = Color.red;
        Handles.DrawWireDisc(cubeExample.transform.position, new Vector3(0, 1, 0), cubeExample.MinRange);
        Handles.DrawWireDisc(cubeExample.transform.position, new Vector3(0, 1, 0), cubeExample.MaxRange);
    }
}
public class CubeExample : MonoBehaviour
{
    public float MinRange = 3.0f;
    public float MaxRange = 5.0f;

    public GameObject instantiateObject;
    // i could just use math instead of another gameobject
    public GameObject SpawnPoint;

    public float spawnTime;
    private float counter;
    private void FixedUpdate()
    {
        counter++;

        if (counter >= spawnTime)
        {
            counter = 0;
            SpawnEnemy(instantiateObject);
        }

    }

    private void SpawnEnemy(GameObject enemy)
    {
        // whym the fuck does this not set a rotation between 0 and 360. as long as it works i suppose
        transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        SpawnPoint.transform.localPosition = new Vector3(transform.position.x + Random.Range(MinRange, MaxRange), transform.position.y, transform.position.z);
        Instantiate(enemy, SpawnPoint.transform.position, new Quaternion(0, 0, 0, 0));
    }



}
