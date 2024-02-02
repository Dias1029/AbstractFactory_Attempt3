using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastSoldier : Soldier
{
    private void Awake()
    {
        moveSpeed = 400f;
        health = 1;
    }
}
