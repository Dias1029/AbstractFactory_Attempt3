using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    List<Transform> portals;
    int i = 0;

    Timer timer;

    private void Start()
    {
        portals = new List<Transform>();

        timer = gameObject.AddComponent<Timer>();
        timer.Duration = Random.Range(2, 5);
        timer.Run();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 15;
            mouseWorldPosition.x = 0;

            var soldierPortalGameObject = Resources.Load("Prefabs/SoldierPortal") as GameObject;
            if (soldierPortalGameObject != null)
            {
                var soldierPortal = Instantiate(
                    soldierPortalGameObject.transform,
                    mouseWorldPosition,
                    Quaternion.identity
                    );
                soldierPortal.gameObject.AddComponent<SoldierFactory>();
                portals.Add(soldierPortal);
            }
            else
            {
                throw new System.ArgumentException("Prefab does not exist.");
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 15;
            mouseWorldPosition.x = -5;

            var tankPortalGameObject = Resources.Load("Prefabs/TankPortal") as GameObject;
            if (tankPortalGameObject != null)
            {
                var tankPortal = Instantiate(
                    tankPortalGameObject.transform,
                    mouseWorldPosition,
                    Quaternion.identity
                    );
                tankPortal.gameObject.AddComponent<TankFactory>();
                portals.Add(tankPortal);
            }
            else
            {
                throw new System.ArgumentException("Prefab does not exist.");
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 15;
            mouseWorldPosition.x = 5;

            var planePortalGameObject = Resources.Load("Prefabs/PlanePortal") as GameObject;
            if (planePortalGameObject != null)
            {
                var planePortal = Instantiate(
                    planePortalGameObject.transform,
                    mouseWorldPosition,
                    Quaternion.identity
                    );
                planePortal.gameObject.AddComponent<PlaneFactory>();
                portals.Add(planePortal);
            }
            else
            {
                throw new System.ArgumentException("Prefab does not exist.");
            }
        }

        if (timer.Finished)
        {
            if (i < portals.Count)
            {
                portals[i].gameObject.GetComponent<EnemyFactory>().portaltransform = portals[i];

                if (Random.Range(0, 2) == 0)
                {
                    portals[i].gameObject.GetComponent<EnemyFactory>().FastEnemyCreation();
                }
                else
                {
                    portals[i].gameObject.GetComponent<EnemyFactory>().SlowEnemyCreation();
                }
                i++;
            }
            else
            {
                i = 0;
            }
            timer.Duration = Random.Range(2, 5);
            timer.Run();
        }
    }
}
