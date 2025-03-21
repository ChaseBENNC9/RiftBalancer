using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public const float MOVE_SPEED = 5f;
    public const float JUMP_HEIGHT = 3;
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
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.gameObject.transform.position = new Vector3(gameObject.transform.position.x,Camera.main.gameObject.transform.position.y,-10);
        if (enableMovement)
        {

        rb.linearVelocityX = moveDir.x*MOVE_SPEED;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
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
