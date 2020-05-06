using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpriteDirections : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public List<Sprite> spriteDir = new List<Sprite>() { 

    };

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void setSprite(int index)
    {
        spriteRenderer.sprite = spriteDir[index];
    }


}
