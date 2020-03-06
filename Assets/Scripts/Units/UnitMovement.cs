using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class UnitMovement : MonoBehaviour
{

    public Tilemap tilemap;

    public Vector3Int tilePos;
    public Vector3 currentPos;
    public Vector3 mousePos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            tilePos = tilemap.WorldToCell(Camera.main.ScreenToWorldPoint(mousePos));
            
            this.transform.position = tilemap.GetCellCenterWorld(tilePos);

        }
    }
}
