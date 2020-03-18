using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BaseUnit : MonoBehaviour
{

    [Space(5), Header("Base Stats")]
    public int baseHealth = 5;    
    public int baseMovementSpeed = 5;
    public int baseAttack = 5;
    public int baseAttackRange = 1;
    public bool canFly = false;

    [Space(5), Header("Current Stats")]
    private float actionPoints = 5;
    public float currentHealth = 5;

    [Space(5), Header("Control Variables")]
    
    public bool active = false;
    public bool playerControlled = false;

    


    private void FixedUpdate()
    {
        if (TurnManager.TurnEnds >= 0)
        {
            actionPoints = 2;
        }   
        
        if (active)
        {
            // add glow or UI element (helth/movement) to unit to indicate current units turn
        }
    }

  
}
