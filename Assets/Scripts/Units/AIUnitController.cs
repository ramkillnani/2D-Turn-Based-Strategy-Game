using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIUnitController : MonoBehaviour
{
    BaseUnit unit;

    public float moveTimer = .5f;


    void Start()
    {
        //unit = units[currU]
    }

    // Update is called once per frame
    void Update()
    {
        if (unit.active)
        {
            if (!unit.playerControlled)
            {
                CalculateAITurn();
            }

        }
    }

    public static void CalculateAITurn()
    {
        Debug.Log("AI Unit Turn: " + UnitManager.gameUnits[UnitManager.currUnitTurn].name);
        // Do AI Turn

    }
}
