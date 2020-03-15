using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varient : BaseUnit
{
    public int unitTypeHealth = 5;
    public int unitTypeSpeed = 5;
    public int unitTypeAttack = 5;
    public int unitTypeRange = 1;
    public bool unitTypeflys = false;
    
    // hmm do we need this?

    private void Start()
    {
        baseMovementSpeed = unitTypeSpeed;
        baseHealth = unitTypeHealth;   

        
    }
}
