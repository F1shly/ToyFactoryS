using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    Shmoovment shmoovment;

    public Vector2 movementInp;
    public Vector2 rotationInp;

    public float xInp;
    public float yInp;
    public float rotInpX;

    private void OnEnable()
    {
        if (shmoovment == null)
        {
            shmoovment = new Shmoovment();
            shmoovment.Player.Move.performed += i => movementInp = i.ReadValue<Vector2>();
            shmoovment.Player.Look.performed += i => rotationInp = i.ReadValue<Vector2>();
        }
        shmoovment.Enable();
    }

    private void OnDisable()
    {
        shmoovment.Disable();
    }
    public void HandleAllInputs()
    {
        MovementInputHandler();
    }
    private void MovementInputHandler()
    {
        yInp = movementInp.y;
        xInp = movementInp.x;
        rotInpX = rotationInp.x;
    }
}
