using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Hero
{
    [Header("Archer")]
    public float range = 100;
    public int archerTurn = 0;

    public GameObject[] archers; // Archer model list

    public void FireArrow()
    {
        archerTurn++;
        // If the next archer is in the list
        if(archerTurn > archers.Length)
        {
            archerTurn = 0;
        }

        // Get that archer to fire arrow

        print(name + " has fired an Arrow!");
    }

    public override void Attack()
    {
        FireArrow();
    }

}
