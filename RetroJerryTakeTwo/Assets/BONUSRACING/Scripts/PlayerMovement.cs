using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;


	public float forwardForce = 250f;
	public float sidewaysForce = 500f;
	public float brakeForce = 2000f;
	public float boostForce = 1000f;


	void Start ()
	{

	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		//add forward force for player
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);	

		if (Input.GetKey("d"))
		{
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0);			
		}
		if (Input.GetKey("a"))
		{
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0);			
		}
		if (Input.GetKey ("space")) 
		{
			rb.AddForce (0, 0, -brakeForce * Time.deltaTime);
		}
		if (Input.GetKey ("left shift")) 
		{
			rb.AddForce (0,0, boostForce * Time.deltaTime);
		}
		if (rb.position.y < 1.8f) 
		{
			FindObjectOfType<GameManager>().EndGame();
		}
}
}
