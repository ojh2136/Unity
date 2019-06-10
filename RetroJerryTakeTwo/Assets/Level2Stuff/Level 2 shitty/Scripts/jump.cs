using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class jump : MonoBehaviour {

	public Vector3 up;
	public float jumpForce = 1.0f;
	public int health = 3; 
	public bool isGrounded;
    public Slider healthbar;
	Rigidbody2D rb;
	void Start(){
		rb = GetComponent<Rigidbody2D>();
		up = new Vector3(0.0f, 2.0f, 0.0f);
	}
    // Is ground
	void OnCollisionEnter2D()
	{
		isGrounded = true;
	}
    // jump mechanicss
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.AddForce(up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
        healthbar.value = health;
    }
    // game over
    private void FixedUpdate()
    {
        if (health <= 0 )
        {
            FindObjectOfType<GameOverLevelOne>().EndGame();
        }
    }

}