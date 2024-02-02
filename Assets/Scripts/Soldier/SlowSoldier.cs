using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowSoldier : Soldier
{
    private void Awake()
    {
        moveSpeed = 800f;
        health = 1;
    }
}
