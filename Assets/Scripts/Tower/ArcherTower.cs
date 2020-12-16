﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherTower : Tower
{
    
    protected override IEnumerator Shoot()
    {
        Minions[] minionsInRange = {};
        // TODO: Add condition (with round end)
        while (true)
        {
            yield return new WaitUntil( () =>
            {
                minionsInRange = MinionsInRange();
                return minionsInRange.Length != 0;
            });
            // TODO: Take damage + spawn arrow
            print("shoot on " +  minionsInRange[0]);
            minionsInRange[0].takeDmg(CurrLevel.damage); //ask oli where dmg is for tower
            
            yield return new WaitForSeconds(CurrLevel.secPerShot);
        }
    }
    
}
