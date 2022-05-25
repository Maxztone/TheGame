using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    Transform _groundCheck;

    [SerializeField]
    Transform _viewPoint;

    [SerializeField]
    public Transform _missileSpawnPos;

    [SerializeField]
    public Object _missile;

    [SerializeField]
    internal PlayerInputScript _playerInputScript;

    [SerializeField]
    public Missile _missileScript;

    //public Joystick joystick;

    internal Animator animator;
    internal Rigidbody2D rb2d;
    internal SpriteRenderer spriteRenderer;
    internal float thrustForce = 25;
    internal float rotationForce = 3;
    internal Object _missileRef;
    private float horizontalMove = 2f;
    public int missilesQuantity = 3;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        _missileRef = Resources.Load("Missile");
        _missileScript.GetComponent<Missile>();
    }

    private void Update()
    {
        //horizontalMove = joystick.Horizontal * 8f;
        DoShoot();
    }

    private void DoShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (missilesQuantity > 0)
            {
                Instantiate(_missile, _missileSpawnPos.position, _missileSpawnPos.rotation);
                missilesQuantity -= 1;
                if (_playerInputScript.isFireLeft)
                {
                    _missileScript.speed = -8;
                }
                else
                {
                    _missileScript.speed = 8;
                }
            }
            else 
            {
                Debug.Log("Missiles is None");
            }
        }
    }

    private void FixedUpdate()
    {
        //if (_playerInputScript.isLeftPressed)
        //{
        //    Vector3 endPos = _missileSpawnPos.position + transform.right * -10f;
        //    Debug.DrawLine(_missileSpawnPos.position, endPos, Color.red);
        //}
        //if (!_playerInputScript.isLeftPressed)
        //{
        //    Vector3 endPos = _missileSpawnPos.position + transform.right * 10f;
        //    Debug.DrawLine(_missileSpawnPos.position, endPos, Color.red);
        //}
    }

}
