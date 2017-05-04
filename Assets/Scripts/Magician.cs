using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magician : Hero
{
    [Header("Magician")]
    public float range = 50f;
    
    public void FireOrb()
    {
        print(name + " has fired an Orb!");
    }

    public void FireLaser()
    {
        print(name + " has fired a Laser!");
    }

    // 'override' means to change the action when "Attack" is called from Hero
    public override void Attack()
    {
        FireOrb();
    }
}
