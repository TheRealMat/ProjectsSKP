﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileInteract : MonoBehaviour
{
    public Grid grid; //Set a Grid or Tilemap object to this in the Editor
    public Tilemap tileMap; //Set a Tilemap object to this in the Editor
    public RuleTile selectedTile;
    public void Update()
    {

        //Left click
        if (Input.GetMouseButton(0))
        {
            ////Display tile position in log
            //Debug.Log(coordinate);
            ////Display the sprite value of the tile in log *SUCCESS*
            //Debug.Log(tileMap.GetSprite(coordinate));

            //ChangeTile(coordinate, null);

            if (TileAdjacent(WorldToTilePos(GetMousePosition())))
            {
                // Set tile to selectedTile
                ChangeTile(WorldToTilePos(GetMousePosition()), selectedTile);
            }
        }
        //Right click
        if (Input.GetMouseButton(1))
        {
            // Set tile to null
            ChangeTile(WorldToTilePos(GetMousePosition()), null);
        }
    }

    // checks if any tiles exist adjacent to coordinate
    public bool TileAdjacent(Vector3Int coordinate)
    {
        // sue me
        if (TileExists(new Vector3Int(coordinate.x + 1, coordinate.y, coordinate.z)))
        {
            return true;
        }
        if (TileExists(new Vector3Int(coordinate.x - 1, coordinate.y, coordinate.z)))
        {
            return true;
        }
        if (TileExists(new Vector3Int(coordinate.x, coordinate.y + 1, coordinate.z)))
        {
            return true;
        }
        if (TileExists(new Vector3Int(coordinate.x, coordinate.y - 1, coordinate.z)))
        {
            return true;
        }
        return false;
    }

    // does a tile exist at this coordinate?
    public bool TileExists(Vector3Int coordinate)
    {
        // returns true or false
        return tileMap.GetSprite(coordinate) != null;
    }

    public Vector3 GetMousePosition()
    {
        //Get position of the mouseclick
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return mouseWorldPos;
    }

    public Vector3Int WorldToTilePos(Vector3 worldPos)
    {
        //Convert position of the mouseclick to the position of the tile located at the mouseclick
        Vector3Int coordinate = grid.WorldToCell(worldPos);
        return coordinate;
    }


    public void ChangeTile(Vector3Int coordinate, RuleTile tile)
    {
        tileMap.SetTile(coordinate, tile);
    }

}
