using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFindDebug : MonoBehaviour
{
    private static PathFindDebug instance;

    public static PathFindDebug myDebug
    {
        get
        {
            if ( instance == null)
            {
                instance = FindObjectOfType<PathFindDebug>();
            }

            return instance;
        }
    }

    [SerializeField]
    private Grid grid;

    //private Tile tile;
        
}
