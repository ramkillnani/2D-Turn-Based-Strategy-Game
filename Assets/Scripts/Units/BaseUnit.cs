using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUnit : MonoBehaviour
{

    [Space(5), Header("Base Stats")]
    public float health = 5;
    public float currentHealth = 5;
    public float movementSpeed = 5;
    public float baseAttack = 5;
    public float attackRange = 1;
    public bool flys = false;

    [Space(5), Header("Control Variables")]
    public bool active = false;
    public bool playerControlled = false;



    private void Start()
    {
        
    }


    private void FixedUpdate()
    {
        
        
    }


    public void MoveLeft()
    {
        /* 
         *  if an enemy occupies target tile
         *      attack enemy on target tile         *      
         *  otherwise
         *  if unit can fly
         *      move left and reduce movemtpoints by 1
         *  otherwise
         *      Check if tile to left is movable
         *      if tile is movable, 
         *          move to the left and reduce movemtpoints by 1      
         *  otherwise
         *      do nothing
         * 
         */
    }


}
