using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carController : MonoBehaviour {

	public float carSpeed;
	public float maxPos = 8.02f;
	Vector3 position;



	// Use this for initialization
	void Start () {
		position = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
		position.x = Mathf.Clamp (position.x, -8.03f, 8.02f);
		transform.position = position;

	}
    // collision detects for enemy can key
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy") 
		{
            FindObjectOfType<GameOverLevelOne>().EndGame();
			Destroy (gameObject);

		}

		if (col.gameObject.tag == "Key") 
		{
	
			SceneManager.LoadScene("InstructionLevelThree");
		}
			
	}
}
