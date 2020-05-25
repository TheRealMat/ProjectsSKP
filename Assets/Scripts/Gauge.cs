using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gauge : MonoBehaviour
{
    public Movement scroll;
    public float mph;
    void Update()
    {
        mph = scroll.speed * 2.2f;

        // i don't use real speeds so this is just pretending
        mph *= 4;


        float clamped = Mathf.Clamp(mph, 0, 360);
        transform.localRotation = Quaternion.Euler(0, clamped, 0);  //Set Rotation value of y  to 180 and rest 0;
    }
}
