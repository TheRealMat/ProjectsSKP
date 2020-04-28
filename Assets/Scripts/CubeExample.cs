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

    private void Update()
    {
        Instantiate(instantiateObject, GetRandomPointBetweenTwoCircles(MinRange, MaxRange), new Quaternion(0,0,0,0));
        Debug.Log(GetRandomPointBetweenTwoCircles(MinRange, MaxRange)); ;
    }
















    // arcane math below
    // it's supposed to get a point between circles but it just gets one at the minRange

    /// <summary>
    /// Returns a random point in the space between two concentric circles.
    /// </summary>
    /// <param name="minRadius"></param>
    /// <param name="maxRadius"></param>
    /// <returns></returns>
    Vector3 GetRandomPointBetweenTwoCircles(float minRadius, float maxRadius)
    {
        //Get a point on a unit circle (radius = 1) by normalizing a random point inside unit circle.
        Vector3 randomUnitPoint = Random.insideUnitCircle.normalized;
        //Now get a random point between the corresponding points on both the circles
        return GetRandomVector3Between(randomUnitPoint * minRadius, randomUnitPoint * maxRadius);
    }

    /// <summary>
    /// Returns a random vector3 between min and max. (Inclusive)
    /// </summary>
    /// <returns>The <see cref="UnityEngine.Vector3"/>.</returns>
    /// <param name="min">Minimum.</param>
    /// <param name="max">Max.</param>
    Vector3 GetRandomVector3Between(Vector3 min, Vector3 max)
    {
        Vector3 point = min + Random.Range(0, 1) * (max - min);
        return new Vector3(point.x, transform.position.y, point.y);
    }


}
