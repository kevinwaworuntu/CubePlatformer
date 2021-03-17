using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private PlayerManager playerManager;
    [SerializeField] private AudioManager audioManager;

    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private int extraJumpValue;
    private int extraJump;
    [SerializeField] private Rigidbody2D rb;
    private float moveInput;
    private bool facingRight;


    [SerializeField] private bool isGrounded;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float checkRadius;
    [SerializeField] private LayerMask groundLayer;


    //for Input
    private void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        if (isGrounded)
        {
            extraJump = extraJumpValue;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump > 0)
        {
            Jump(jumpForce);
            extraJump--;     
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump == 0 && isGrounded)
        {
            
            Jump(jumpForce);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && playerManager.isInteractable == true)
        {

            switch (playerManager.eventNumber)
            {
                case 1:
                    playerManager.event1.Invoke();
                    return;
            }
        }
        else
        { 
            return;
        }
    }
    //for movement
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);
        rb.velocity = new Vector2(moveInput * movementSpeed, rb.velocity.y);
        
        if (facingRight && moveInput > 0) Flip();
        else if (!facingRight && moveInput < 0) Flip();
        
    }
    private void Jump(float jump)
    {
        audioManager.jumpSFX();
        rb.velocity = Vector2.up * jump;
    }
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
