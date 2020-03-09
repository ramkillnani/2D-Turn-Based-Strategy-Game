using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class UnitMovement : MonoBehaviour
{

    public Tilemap tilemap;

    public TileBase baseTile;

    public Vector3Int tilePos;
    public Vector3 currentPos;
    public Vector3 mousePos;

    public Vector3Int tileLeft;
    public Vector3Int tileUpLeft;
    public Vector3Int tileDownLeft;
    public Vector3Int tileRight;
    public Vector3Int tileUpRight;
    public Vector3Int tileDownRight;

    

    // Update is called once per frame

    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            tilePos = tilemap.WorldToCell(Camera.main.ScreenToWorldPoint(mousePos));


            if (tilePos.x > currentPos.x)
            {
                // check right tile
                // else check up right
                // else check bot right
            }
            
            this.transform.position = tilemap.GetCellCenterWorld(tilePos);

            GetAdjacentTiles();            
        }
    }

    void GetAdjacentTiles()
    {

        //if (tilemap.HasTile(new Vector3(this.transform.position.x + 1, this.transform.position.y)))
        //{

        //}
        tileRight = tilemap.WorldToCell(new Vector3(this.transform.position.x + 1, this.transform.position.y));
        tilemap.SetTile(tileRight, baseTile);

        tileUpRight = tilemap.WorldToCell(new Vector3(this.transform.position.x + .5f, this.transform.position.y + .75f));
        tilemap.SetTile(tileUpRight, baseTile);
    }
}
