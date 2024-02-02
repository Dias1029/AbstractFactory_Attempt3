using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierFactory : EnemyFactory
{
    public override void FastEnemyCreation()
    {
        var portalTransformPosition = portaltransform.transform.position;
        var fastSoldierGameObject = Resources.Load("Prefabs/FastSoldier") as GameObject;
        if (fastSoldierGameObject != null )
        {
            var fastSoldier = Instantiate(
                fastSoldierGameObject.transform,
                new Vector3(
                    portalTransformPosition.x,
                    portalTransformPosition.y,
                    portalTransformPosition.z
                    ),
                Quaternion.identity
                );
        }
        else
        {
            throw new System.ArgumentException("Prefab does not exist.");
        }
    }

    public override void SlowEnemyCreation()
    {
        var portalTransformPosition = portaltransform.transform.position;
        var slowSoldierGameObject = Resources.Load("Prefabs/SlowSoldier") as GameObject;
        if (slowSoldierGameObject != null)
        {
            var slowSoldier = Instantiate(
                slowSoldierGameObject.transform,
                new Vector3(
                    portalTransformPosition.x,
                    portalTransformPosition.y,
                    portalTransformPosition.z
                    ),
                Quaternion.identity
                );
        }
        else
        {
            throw new System.ArgumentException("Prefab does not exist.");
        }
    }
}
