using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public AimGun aimGun;
    public Rigidbody2D rb2d;
    public Gun[] guns;
    public EnemyMover enemyMover;
    internal SpriteRenderer spriteRenderer;
    //public float maxSpeed = 10;
    //private Vector2 movementVector;
    //public float rotationSpeed = 100;
    //public Transform tankTower;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (enemyMover == null)
            enemyMover = GetComponentInChildren<EnemyMover>();
        if (aimGun == null)
            aimGun = GetComponentInChildren<AimGun>();
        if (guns == null || guns.Length == 0)
        {
            guns = GetComponentsInChildren<Gun>();
        }
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void HandleMoveBody(Vector2 movementVector)
    {
        enemyMover.Move(movementVector);
        if (movementVector.x == 1)
            spriteRenderer.flipX = true;
        else if(movementVector.x == -1)
            spriteRenderer.flipX = false;
    }

    public void HandleShoot()
    {
        foreach (var gun in guns)
        {
            gun.Shoot();
        }
    }

    public void HandleTurretMovement(Vector2 pointerPosition)
    {
        aimGun.Aim(pointerPosition);
    }
}
