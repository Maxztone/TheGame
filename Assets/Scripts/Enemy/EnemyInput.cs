using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyInput : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    public UnityEvent<Vector2> OnTowerMovement = new UnityEvent<Vector2>();

    private void Update()
    {
        GetTowerMovement();
    }

    private void GetTowerMovement()
    {
        OnTowerMovement?.Invoke(GetMousePosition());
    }

    private Vector2 GetMousePosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = mainCamera.nearClipPlane;
        Vector2 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
        return mouseWorldPosition;
    }
}
