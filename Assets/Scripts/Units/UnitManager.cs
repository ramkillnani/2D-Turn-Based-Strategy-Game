using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    
    public static int currUnitTurn;

    // List of Units on the map, ordered by which one goes first     
    public static List<BaseUnit> gameUnits;

    public GameObject gameWorld;

    void Awake()
    {
        gameUnits = new List<BaseUnit>();
        foreach (BaseUnit unit in gameWorld.GetComponentsInChildren<BaseUnit>())
        {
            if (unit != null)
            { 
                gameUnits.Add(unit);
                //units[i] = unit;
                Debug.Log(unit.gameObject.name + " : " + unit.baseAttack);
            }

        }
    }



        //private static UnitManager instance;

        //// Index of current Unit's Turn    
        //[SerializeField]
        //public static int currUnitTurn;

        //// List of Units on the map, ordered by which one goes first     
        //List<GameObject> units;



        //public static UnitManager Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = FindObjectOfType<UnitManager>();
        //        }

        //        return instance;
        //    }
        //}

    }
