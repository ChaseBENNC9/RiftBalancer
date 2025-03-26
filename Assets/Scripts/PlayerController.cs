using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public const float BASE_SPEED = 5f;
    public float currentSpeed; 
    public float JUMP_HEIGHT = 3;
    public Transform groundCheck;
    public LayerMask groundLayer; 
    public float groundCheckRadius = 0.2f;
    private bool isGrounded;
    private Vector2 moveDir;
    private Rigidbody2D rb;
    [HideInInspector] public  bool enableMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enableMovement = true;
        rb = GetComponent<Rigidbody2D>();
        currentSpeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (enableMovement)
        {

            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
            rb.linearVelocityX = moveDir.x*currentSpeed*BASE_SPEED;
        }
        else
        {
            rb.linearVelocityX = 0;
        }
    }
    public void OnMove(InputAction.CallbackContext c)
    {
        if (c.performed)
            Debug.Log("TEST");
            moveDir = c.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext c)
    {
        if (c.performed && isGrounded)
            rb.AddForce(Vector2.up*JUMP_HEIGHT,ForceMode2D.Impulse);
    }
}
