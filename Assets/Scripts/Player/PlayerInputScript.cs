using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    [SerializeField]
    PlayerScript _playerScript;

    internal bool isLeftPressed;
    internal bool isRightPressed;
    internal bool isUpPressed;
    internal bool isFirePressed;
    internal bool isDownPressed;
    internal bool isFireLeft = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFirePressed = true;
        }
        else
        {
            isFirePressed = false;
        }

        if (Input.GetKey(KeyCode.W))
        {
            isUpPressed = true;
        }

        else
        {
            isUpPressed = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            isLeftPressed = true;
            isFireLeft = true;
        }

        else
        {
            isLeftPressed = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            isRightPressed = true;
            isFireLeft = false;
        }

        else
        {
            isRightPressed = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            isDownPressed = true;
        }

        else
        {
            isDownPressed = false;
        }
    }
}
