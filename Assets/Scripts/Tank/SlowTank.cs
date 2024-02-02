using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTank : Tank
{
    private void Awake()
    {
        moveSpeed = 200f;
        health = 8;
    }
}
