using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPlatMove : MonoBehaviour {
	public enum type {platformer, topDown};
	public type moveType;
	public float moveSpeed, jumpHeight = 1.0f;
	public bool onGround = false;
	private bool facingRight = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetAxisRaw ("Horizontal") > 0) 
		{
			transform.Translate (Vector2.right * Time.deltaTime * moveSpeed);
		}	
		else if (Input.GetAxisRaw ("Horizontal") < 0) 
		{
			transform.Translate (Vector2.left * Time.deltaTime * moveSpeed);
		}	
		if (moveType == type.platformer && Input.GetAxisRaw ("Vertical") > 0 && onGround) 
		{
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * jumpHeight, ForceMode2D.Impulse);
			onGround = false;
		}
	}

	void OnCollisionEnter2D (Collision2D obj)
	{
		if (obj.gameObject.tag == "ground") 
		{
			onGround = true;

		}
	}
	void Flip()
	{
		facingRight = !facingRight;
		transform.Rotate(0f, 180f, 0f);
	}


}
