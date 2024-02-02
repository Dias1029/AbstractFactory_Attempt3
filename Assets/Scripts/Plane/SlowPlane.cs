using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowPlane : Plane
{
    private void Awake()
    {
        moveSpeed = 200f;
        health = 3;
    }
}
