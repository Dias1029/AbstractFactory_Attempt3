using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastTank : Tank
{
    private void Awake()
    {
        moveSpeed = 400f;
        health = 8;
    }
}
