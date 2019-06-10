using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class boss : MonoBehaviour {

    public int health;
    public int damage;
    public float speed;
    private Transform target;
    private float timeDamage = 1.5f;
    public bool isDead;
    private Animator anim;

    public Slider healthBar;
	void Start () {
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if (timeDamage > 0)
        {
            timeDamage -= Time.deltaTime;
        }

        healthBar.value = health;
        if (health <= 0)
        {
            anim.SetTrigger("death");
        }
       
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);    
      
	}
    private void FixedUpdate()
    {
        if (health <= 0)
        {
            FindObjectOfType<GameOver>().EndGameWin();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //boss dealing damage
        if (other.CompareTag("Player") && isDead == false)
        {
            if (timeDamage <= 0)
            {
                other.GetComponent<PlayerMovementFinalLevel>().health -= damage;
                Debug.Log(other.GetComponent<PlayerMovementFinalLevel>().health -= damage);
            }
        }
    }


}
