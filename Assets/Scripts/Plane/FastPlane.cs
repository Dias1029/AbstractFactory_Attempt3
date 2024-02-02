using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastPlane : Plane
{
    private void Awake()
    {
        moveSpeed = 300f;
        health = 3;
    }
}
