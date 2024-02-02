using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : Enemy
{
    public override EnemyType GetEnemyType()
    {
        return EnemyType.Soldier;
    }
}
