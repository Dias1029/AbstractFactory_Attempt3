using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float moveSpeed = 0f;
    public int health = 0;

    Timer timer;

    public enum EnemyType
    {
        Soldier,
        Tank,
        Plane
    }

    public abstract EnemyType GetEnemyType();

    private void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 15;
        timer.Run();
    }

    private void Update()
    {
        transform.position += -transform.right * moveSpeed * Time.deltaTime;

        if (timer.Finished)
        {
            Destroy(gameObject);
        } // It's unnecessary
    }
}
