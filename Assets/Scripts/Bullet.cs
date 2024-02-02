using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    float movementSpeed = 200;

    Timer timer;

    private void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 15;
        timer.Run();

        rb.AddForce(-transform.forward * movementSpeed);
    }

    private void Update()
    {
        if (timer.Finished)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Enemy>().health--;

        if (other.gameObject.GetComponent<Enemy>().health == 0)
        {
            Destroy(other.gameObject);
        }

        Destroy(gameObject);
    }
}
