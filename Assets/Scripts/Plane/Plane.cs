using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enemy;

public class Plane : Enemy
{
    public override EnemyType GetEnemyType()
    {
        return EnemyType.Plane;
    }
}
