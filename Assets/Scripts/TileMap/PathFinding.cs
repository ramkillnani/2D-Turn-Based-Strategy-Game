using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum TileType
{
    Clear,
    Slow,
    Blocked
}

public class PathFinding : MonoBehaviour
{

    public Tilemap tileMap;

    private TileType tileType;

    //list of tiles
    [SerializeField]
    private ATile[] tiles;


    // current unit position
    public Vector3 currentPos;
    // pos position on click
    public Vector3 mousePos;
    // goal tile position
    public Vector3Int tilePos;

    //Maybe needed if using ray casts not using ray casts atm)
    private LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        getTileMapMesh();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            tilePos = tileMap.WorldToCell(Camera.main.ScreenToWorldPoint(mousePos));

            if (tilePos != null)
            {

                if (tilePos.x > currentPos.x)
                {
                    // check right tile
                    // else check up right
                    // else check bot right
                }


                //this.transform.position = tileMap.GetCellCenterWorld(tilePos);
                //Debug.Log(tileMap.cellBounds);
                //GetAdjacentTiles();
            }
        }
    }

    void getTileMapMesh()
    {
        //tileMap.
        Grid grid = tileMap.layoutGrid;
        
        
        //Debug.Log(grid.cellLayout + " " + tileMap.cellBounds);


    }
}
