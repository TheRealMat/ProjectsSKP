using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gauge : MonoBehaviour
{
    public Movement scroll;
    void Update()
    {
        float kmph = scroll.speed * 3.6f;
        float clamped = Mathf.Clamp(kmph, 0, 360);
        transform.localRotation = Quaternion.Euler(0, clamped, 0);  //Set Rotation value of y  to 180 and rest 0;
    }
}
