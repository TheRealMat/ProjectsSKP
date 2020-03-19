using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileInteract : MonoBehaviour
{
    public Grid grid; //Set a Grid or Tilemap object to this in the Editor
    public Tilemap tileMap; //Set a Tilemap object to this in the Editor
    public void Update()
    {

        //Detect when mouse is clicked
        if (Input.GetMouseButtonDown(0))
        {
            //Get position of the mouseclick
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Convert position of the mouseclick to the position of the tile located at the mouseclick
            Vector3Int coordinate = grid.WorldToCell(mouseWorldPos);

            //Display tile position in log
            Debug.Log(coordinate);
            //Display the sprite value of the tile in log *SUCCESS*
            Debug.Log(tileMap.GetSprite(coordinate));

            // get reference to tile
            tileMap.GetTile(coordinate);

            DeleteTile(coordinate);
        }
    }
    public void DeleteTile(Vector3Int coordinate)
    {
        tileMap.SetTile(coordinate, null);
    }
}
