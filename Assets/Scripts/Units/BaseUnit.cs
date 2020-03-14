using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUnit : MonoBehaviour
{

    [Space(5), Header("Base Stats")]
    public float baseHealth = 5;    
    public float baseMovementSpeed = 5;
    public float baseAttack = 5;
    public float baseAttackRange = 1;
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
