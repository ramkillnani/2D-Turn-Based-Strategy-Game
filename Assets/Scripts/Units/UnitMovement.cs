using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;



public class UnitMovement : MonoBehaviour
{

    public Tilemap tileMap;
    public TileBase baseTile;
    private TileType tileType;

    // current unit position
    public Vector3 currentPos;
    // pos position on click
    public Vector3 mousePos;
    // goal tile position
    public Vector3Int tilePos;

    // unity type
    //public unitType

    // positions of adjacent tile to the current unit tile
    private Vector3Int tileLeft;
    private Vector3Int tileUpLeft;
    private Vector3Int tileDownLeft;
    private Vector3Int tileRight;
    private Vector3Int tileUpRight;
    private Vector3Int tileDownRight;

    // remember to change back to private
    public int[][] tileMesh;

    //how fast the unit trabels over the map visually
    public float visualMovementSpeed = .001f;

    //Pathfinding
    //Meta defining play here

    public int teamNum;
    public int x;
    public int y;

    public int actionPoints;


    public Queue<int> movementQueue;
    public Queue<int> combatQueue;

    public List<Node> path = null;

    //Path for moving unit's transform
    public List<Node> pathForMovement = null;
    public bool completedMovement = false;


    private void Start()
    {
        //movPointsAv = 
    }


    void Update()
    {
        if (teamNum == 0)
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

                    //this.transform.position = Vector3.Lerp(this.transform.position, tileMap.GetCellCenterWorld(tilePos), visualMovementSpeed);
                    StartCoroutine(moveOverSeconds(transform.gameObject, tilePos));


                    ATile aTile;
                    aTile = (ATile)tileMap.GetTile(tilePos);
                    Debug.Log(aTile.movementSpeed + " : ");

                    //GetAdjacentTiles();
                }
            }
        }
        else //AI's turn
            AIUnitController.CalculateAITurn();
    }


    #region BasicMovement
        
    public void MoveLeft()
    {
        if (actionPoints >= 1)
        {

            // below will be put into UnitMovement script

            /* 
             *  if an enemy occupies target tile
             *      attack enemy on target tile         *      
             *  otherwise
             *  if unit can fly
             *      move left and reduce movemtpoints by 1
             *  otherwise
             *      Check if tile to left is movable
             *      if tile is movable, 
             *          move to the left and reduce movemtpoints by 1      
             *  otherwise
             *      do nothing
             * 
             */
        }
        else
        {

        }
    }

    #endregion


    void GetAdjacentTiles()
    {

        //if (tilemap.HasTile(new Vector3(this.transform.position.x + 1, this.transform.position.y)))
        //{

        //}


        tileRight = tileMap.WorldToCell(new Vector3(this.transform.position.x + 1, this.transform.position.y));
        tileMap.SetTile(tileRight, baseTile);

        tileUpRight = tileMap.WorldToCell(new Vector3(this.transform.position.x + .5f, this.transform.position.y + .75f));
        tileMap.SetTile(tileUpRight, baseTile);

        
    }

    public IEnumerator moveOverSeconds(GameObject objectToMove, Vector3Int endTile)
    {
        while (this.transform.position != tileMap.GetCellCenterWorld(endTile))
        {
            this.transform.position = Vector3.Lerp(this.transform.position, tileMap.GetCellCenterWorld(endTile), visualMovementSpeed);
            yield return new WaitForEndOfFrame();
        }

    }

    //public IEnumerator moveOverSeconds(GameObject objectToMove, Node endNode)
    //{
    //    movementQueue.Enqueue(1);

    //    //remove first thing on path because, its the tile we are standing on

    //    path.RemoveAt(0);
    //    while (path.Count != 0)
    //    {

    //        Vector3 endPos = map.tileCoordToWorldCoord(path[0].x, path[0].y);
    //        objectToMove.transform.position = Vector3.Lerp(transform.position, endPos, visualMovementSpeed);
    //        if ((transform.position - endPos).sqrMagnitude < 0.001)
    //        {

    //            path.RemoveAt(0);

    //        }
    //        yield return new WaitForEndOfFrame();
    //    }
    //    visualMovementSpeed = 0.15f;
    //    transform.position = map.tileCoordToWorldCoord(endNode.x, endNode.y);

    //    x = endNode.x;
    //    y = endNode.y;
    //    tileBeingOccupied.GetComponent<ClickableTileScript>().unitOnTile = null;
    //    tileBeingOccupied = map.tilesOnMap[x, y];
    //    movementQueue.Dequeue();

    //}


}
