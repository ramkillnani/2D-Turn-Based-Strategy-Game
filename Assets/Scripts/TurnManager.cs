using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public int turnNumber = 0;
    public Text turnText;
    public static bool endOfPlayerTurn;
    public static bool endOfEnemyTurn;
    public static float TurnEnds = 1;

    private BaseUnit thisUnit;
    
    // Start is called before the first frame update
    void Start()
    {
        UnitManager.currUnitTurn = 0;
        thisUnit = UnitManager.gameUnits[UnitManager.currUnitTurn];
        thisUnit.active = true;
    }
    
    public void NextTurn()
    {
        turnNumber += 1;
        TurnEnds += 1;

        //deactivate current Unit
        thisUnit.active = false; 

        // change unit's Turn
        // if the number of units in the unit array is greater than the current unit's index
        if (UnitManager.gameUnits.Count > UnitManager.currUnitTurn + 1)
            UnitManager.currUnitTurn++; // increase the index for current by 1
        else
            UnitManager.currUnitTurn = 0; // restart at the begining of the available units

        //actiavte next unit
        thisUnit = UnitManager.gameUnits[UnitManager.currUnitTurn];
        thisUnit.active = true;        
    }

    // Update is called once per frame
    void Update()
    {
        turnText.text = " " + turnNumber;
        if (TurnEnds >= 0)
        {
            TurnEnds -= Time.deltaTime;

        }
    }
}
