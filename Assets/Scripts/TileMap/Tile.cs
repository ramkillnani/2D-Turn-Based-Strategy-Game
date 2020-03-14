using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "New Tile", menuName = "Tiles/ATile")]
public class ATile : Tile
{
    [SerializeField]
    public int movementSpeed = 1;
    [SerializeField]
    public bool isWalkable = true;
}


//public class Tile
//{

//    public string name;
//    public GameObject tileVisualPrefab;
//    public GameObject unitOnTile;
//    public float movementCost = 1;
//    public bool isWalkable=true;


//    public TileType tileType;




//    //private int x;
//    //private int y;

//    /*


//    public Tile( int xLocation, int yLocation)
//    {
//        x = xLocation;
//        y = yLocation;
//    }

//    public void setCoords(int xLocation, int yLocation)
//    {
//        x = xLocation;
//        y = yLocation;
//    }
//    */
//}
