using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Enemy
{
    public override EnemyType GetEnemyType()
    {
        return EnemyType.Tank;
    }
}
