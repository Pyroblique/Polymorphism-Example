using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [Header("Hero")]
    public float attackPower = 5f;
    public float attackSpeed = 1f;
    public float costForUpgrade = 100f;
    public int level = 0;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    // 'virtual' means it can be overriden in subclasses
    public virtual void Attack() {}

    public void Upgrade()
    {
        level++; // ++ means 'Add 1 to level'
    }
}
