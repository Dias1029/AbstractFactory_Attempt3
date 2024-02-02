using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFactory : EnemyFactory
{
    public override void FastEnemyCreation()
    {
        var portalTransformPosition = portaltransform.transform.position;
        var fastTankGameObject = Resources.Load("Prefabs/FastTank") as GameObject;
        if (fastTankGameObject != null)
        {
            var fastTank = Instantiate(
                fastTankGameObject.transform,
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
        var slowTankGameObject = Resources.Load("Prefabs/SlowTank") as GameObject;
        if (slowTankGameObject != null)
        {
            var slowTank = Instantiate(
                slowTankGameObject.transform,
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
