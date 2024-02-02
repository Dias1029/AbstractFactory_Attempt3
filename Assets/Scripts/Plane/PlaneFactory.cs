using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFactory : EnemyFactory
{
    public override void FastEnemyCreation()
    {
        var portalTransformPosition = portaltransform.transform.position;
        var fastPlaneGameObject = Resources.Load("Prefabs/FastPlane") as GameObject;
        if (fastPlaneGameObject != null)
        {
            var fastPlane = Instantiate(
                fastPlaneGameObject.transform,
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
        var slowPlaneGameObject = Resources.Load("Prefabs/SlowPlane") as GameObject;
        if (slowPlaneGameObject != null)
        {
            var slowPlane = Instantiate(
                slowPlaneGameObject.transform,
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
