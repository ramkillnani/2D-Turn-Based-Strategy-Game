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
    public static bool PlayerTurn;
    public Image button;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void NextTurn()
    {
        if (PlayerTurn == true)
        {
            PlayerTurn = false;
            
        }
        else
        {
            PlayerTurn = true;
        }
        turnNumber += 1;
        TurnEnds += 1;

        UnitManager.SelectNextUnit();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerTurn == true)
        {
            button.color = Color.blue;
        }
        else
        {
            button.color = Color.red;
        }
        turnText.text = " " + turnNumber;
        if (TurnEnds >= 0)
        {
            TurnEnds -= Time.deltaTime;

        }
    }
}
