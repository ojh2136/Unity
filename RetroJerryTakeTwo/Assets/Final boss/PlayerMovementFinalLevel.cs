using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementFinalLevel : MonoBehaviour {


    public int health;
    public float speed;
    public float runSpeed;
    public float jumpforce;
    private float moveInput;
    public Slider healthbar;
    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool isGrounded;
    private bool isDead = false;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGrounded;

    private int jump;

    public int extraJump;


     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
     void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGrounded);

        //LEft and right
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);

        //Fliping
        if(facingRight == false && moveInput >0)
        {
            Flip();
        } else if (facingRight ==true && moveInput<0)
        {
            Flip();
        }

        if (health <= 0 )
        {
            FindObjectOfType<GameOver>().EndGame();
        }
    }

     void Update()
    {
        if (isGrounded == true)
        {
            jump = extraJump;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && jump > 0)
        {
            rb.velocity = Vector2.up * jumpforce;
            jump--;
        } else if (Input.GetKeyDown(KeyCode.UpArrow) && jump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpforce;
        }
        healthbar.value = health;

    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
