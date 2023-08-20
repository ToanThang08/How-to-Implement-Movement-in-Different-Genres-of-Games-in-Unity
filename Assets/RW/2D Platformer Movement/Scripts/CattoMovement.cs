
using UnityEngine;

public class CattoMovement : MonoBehaviour
{

    // Variables for components
    // 1
    private Rigidbody2D cattoRigidbody2D;
    private Animator cattoAnimator;

    // Bools to check state
    // 2
    private bool cattoIsFacingRight = true;
    private bool cattoIsJumping = false;
    private bool cattoIsGrounded = false;

    // Most common variables
    // 3
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask ground;
    public float moveInput;
    public float cattoSpeed;
    public float cattoJumpForce;

    void Start()
    {
        cattoRigidbody2D = GetComponent<Rigidbody2D>();
        cattoAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        cattoIsGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, ground);
        moveInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {

    }
}
