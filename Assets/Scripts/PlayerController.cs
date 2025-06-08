using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using Unity.Jobs.LowLevel.Unsafe;

public class PlayerController : MonoBehaviour
{
    public const float BASE_SPEED = 2f;
    public const float SPRINT_SPEED = 4.5f;
    public bool isSprinting;
    public float currentSpeed;
    public float JUMP_HEIGHT = 3;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.2f;
    [SerializeField] private bool isGrounded;
    public bool isCasting;
    private Vector2 moveDir;
    private Rigidbody2D rb;
    private Animator animator;
    [HideInInspector] public bool enableMovement;
    [SerializeField] private SpriteRenderer playerSprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isSprinting = false;
        enableMovement = true;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        currentSpeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (enableMovement)
        {

            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
            float speedMultiplier = isSprinting ? SPRINT_SPEED : BASE_SPEED;
            rb.linearVelocityX = moveDir.x * currentSpeed * speedMultiplier;
        }
        else
        {
            rb.linearVelocityX = 0;
        }
        if (rb.linearVelocityX != 0)
            playerSprite.flipX = moveDir.x == -1;

        animator.SetFloat("playerSpeed", MathF.Abs(rb.linearVelocityX));
        animator.SetBool("isGrounded", isGrounded);




    }
    public void OnMove(InputAction.CallbackContext c)
    {
        if (c.performed)
            Debug.Log("TEST");
        moveDir = c.ReadValue<Vector2>();
        Debug.Log(moveDir);
    }

    public void OnJump(InputAction.CallbackContext c)
    {
        if (c.performed && isGrounded)
            rb.AddForce(Vector2.up * JUMP_HEIGHT, ForceMode2D.Impulse);
    }

    public void OnCast(InputAction.CallbackContext c)
    {
        AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
        if (state.IsName("Player_CastSpell") || !isGrounded)
            return;
       else if (c.performed)
        {
            animator.SetTrigger("CastSpell");

        }
    }

        public void OnSlash(InputAction.CallbackContext c)
    {
        AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
        if (state.IsName("Player_Slash") || !isGrounded)
            return;
       else if (c.performed)
        {
            animator.SetTrigger("Slash");

        }
    }

    public void OnSprint(InputAction.CallbackContext c)
    {
        if (c.performed)
            isSprinting = true;
        if (c.canceled)
            isSprinting = false;

    }
}
