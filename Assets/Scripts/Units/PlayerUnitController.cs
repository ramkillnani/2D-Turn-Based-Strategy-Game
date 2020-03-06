using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitController : MonoBehaviour
{
    BaseUnit unit;
    // Start is called before the first frame update
    void Start()
    {
        unit = GetComponent<BaseUnit>();
    }

    // Update is called once per frame
    void Update()
    {
        if (unit.active)
        {
            if (unit.playerControlled)
            {

                // keys movement input
                // check inputs and apply movement or attack if enemy in move square

                // mouse point and click conroller
            }

        }
    }
}
