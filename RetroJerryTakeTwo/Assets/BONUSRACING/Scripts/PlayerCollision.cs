
using UnityEngine;

public class PlayerCollision : MonoBehaviour 
{
	public PlayerMovement movement;

	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle") 
		{
			// if true player can still move if it hits object, if false player stop moving
			movement.enabled = true;
//			FindObjectOfType<GameManager>().EndGame();
		}

	}

}