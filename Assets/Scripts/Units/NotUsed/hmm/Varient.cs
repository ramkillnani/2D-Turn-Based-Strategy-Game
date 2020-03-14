using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varient : BaseUnit
{
    public float unitTypeHealth = 5;
    public float unitTypeSpeed = 5;
    public float unitTypeAttack = 5;
    public float unitTypeRange = 1;
    public bool unitTypeflys = false;
    
    // hmm do we need this?

    private void Start()
    {
        baseMovementSpeed = unitTypeSpeed;
        baseHealth = unitTypeHealth;   

        
    }
}
