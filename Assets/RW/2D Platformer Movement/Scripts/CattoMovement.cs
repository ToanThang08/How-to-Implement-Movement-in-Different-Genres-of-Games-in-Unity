
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

        if (cattoIsGrounded)
        {
            cattoAnimator.SetFloat("Velocity", Mathf.Abs(moveInput));
        }

        if (Input.GetButtonDown("Jump") && cattoIsGrounded)
        {
            cattoIsJumping = true;
            cattoAnimator.SetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && cattoIsGrounded)
        {
            cattoAnimator.SetBool("Crouch", true);
        }

        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            cattoAnimator.SetBool("Crouch", false);
        }
    }

    private void FixedUpdate()
    {

    }

    private void FlipCatto()
    {
        cattoIsFacingRight = !cattoIsFacingRight;

        Vector3 cattoScale = transform.localScale;
        cattoScale.x *= -1;

        transform.localScale = cattoScale;
    }
}
