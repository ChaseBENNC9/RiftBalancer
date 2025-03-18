using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public const float MOVE_SPEED = 5f;
    private Vector2 moveDir;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocityX = moveDir.x*MOVE_SPEED;
    }
    public void OnMove(InputAction.CallbackContext c)
    {
        if (c.performed)
            Debug.Log("TEST");
            moveDir = c.ReadValue<Vector2>();
    }
}
