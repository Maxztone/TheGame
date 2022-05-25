using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    PlayerScript _playerScript;

    private void FixedUpdate()
    {
        if (_playerScript._playerInputScript.isUpPressed)
        {
            MovePlayerUp();
        }
        else if (_playerScript._playerInputScript.isDownPressed)
        {
            MovePlayerDown();
        }
        else if (_playerScript._playerInputScript.isLeftPressed)
        {
            MovePlayerLeft();
        }
        else if (_playerScript._playerInputScript.isRightPressed)
        {
            MovePlayerRight();
        }
        else if (_playerScript._playerInputScript.isRightPressed)
        {
            MovePlayerRight();
        }
    }

    private void MovePlayerRight()
    {
        transform.Rotate(Vector3.back * _playerScript.rotationForce);
        _playerScript.animator.Play("Player_idle");
        _playerScript.spriteRenderer.flipX = false;
    }

    private void MovePlayerLeft()
    {
        transform.Rotate(Vector3.forward * _playerScript.rotationForce);
        _playerScript.animator.Play("Player_idle");
        _playerScript.spriteRenderer.flipX = true;
    }

    private void MovePlayerDown()
    {
        _playerScript.rb2d.AddForce(-transform.up * _playerScript.thrustForce);
        _playerScript.animator.Play("Player_down");
    }

    private void MovePlayerUp()
    {
        _playerScript.rb2d.AddForce(transform.up * _playerScript.thrustForce);
        _playerScript.animator.Play("Player_up");
    }
}
