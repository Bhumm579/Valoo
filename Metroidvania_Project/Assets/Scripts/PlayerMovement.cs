using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float jumpForce = 12f;
    private int extraJumpValue = 1;
    private int extraJump;
    [SerializeField]private bool isGrounded;  
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
        JumpMecanics();
    }

    void FixedUpdate()
    {
        
    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }
    private void JumpMecanics()
    {
        if (isGrounded)
        {
            extraJump = extraJumpValue;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // if (isGrounded)
            // {
                Jump();
            // }
            // else if (extraJump > 0)
            // {
            //     extraJump--;
            //     Jump();
            // }
        }   
    }
}
