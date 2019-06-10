using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jerryPlat : MonoBehaviour {


	public int health;
	public float speed;
	public float runSpeed;
	public float jumpforce = 1.0f;
	private float moveInput;
	public enum type {platformer, topDown};
	public type moveType;
	public float moveSpeed, jumpHeight = 1.0f;
	public bool onGround = false;


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
    //movement mechanic
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
    // jump and death mechanic
	void Update()
	{
		if (moveType == type.platformer && Input.GetAxisRaw ("Vertical") > 0 && onGround) 
		{
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * jumpHeight, ForceMode2D.Impulse);
			onGround = false;
		}
		if (rb.position.y < -3.15f) 
		{
			FindObjectOfType<GameOverLevelOne>().EndGame();
		}
	}
    // fliping jerry
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;
	}
    // ground check
	void OnCollisionEnter2D (Collision2D obj)
	{
		if (obj.gameObject.tag == "ground") 
		{
			onGround = true;

		}
	}
}
