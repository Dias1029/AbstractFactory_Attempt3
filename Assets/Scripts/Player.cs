using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] float playerSpeed = 10f;
    Vector3 playerMovement;

    [SerializeField] private Rigidbody rb;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(
                bulletPrefab,
                transform.position,
                Quaternion.Euler(0, 180, 0)
            );
        }

        playerMovement.x = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + playerMovement * playerSpeed * Time.fixedDeltaTime);
    }
}
