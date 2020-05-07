using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public Component[] components;

    private void Awake()
    {
        components = GetComponentsInChildren<SpriteDirections>();
    }


    void Rotate(int index)
    {
        foreach (SpriteDirections spriteDirections in components)
        {
            spriteDirections.setSprite(index);
        }
    }
}
