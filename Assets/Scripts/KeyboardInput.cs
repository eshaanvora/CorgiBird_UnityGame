using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public Corgi Corgi;

    private bool isInPlay = false;

    public void FixedUpdate()
    {
        HandleInput();
        if (isInPlay == true)
            Corgi.RotateRight();
    }

    private void HandleInput()
    {
        if (Input.GetKey(KeyCode.Space) || (Input.GetButtonDown("Fire1")))
        {
            isInPlay = true;
            Corgi.RotateLeft();
            Corgi.Jump();
        }
    }
}