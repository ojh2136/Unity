using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booster : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce2 = 20000f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			rb.AddForce (0, 0, forwardForce2 * Time.deltaTime);	
		}
	
}
}
