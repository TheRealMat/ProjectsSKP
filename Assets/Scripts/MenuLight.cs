using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLight : MonoBehaviour
{
    private void Update()
    {
        Vector3 position =  Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 3f));
        transform.position = position;
    }
}
