using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public int turnNumber = 0;
    public Text turnText;
   // public static bool endOfPlayerTurn;
   // public static bool endOfEnemyTurn;
    public static float TurnEnds = 1;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void NextTurn()
    {
        turnNumber += 1;
        TurnEnds += 1;

        UnitManager.SelectNextUnit();
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
