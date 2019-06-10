using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float speed =20f;
    public Rigidbody2D rb;
    public int damage = 10;
    public GameObject destroyEffect;
     void Start()
    {
        rb.velocity = transform.right * speed; 
    }
    // range mechanic for jerry
    void OnTriggerEnter2D (Collider2D other)
    {
        if ( other.GetComponent<boss>() != null)
        {
            other.GetComponent<boss>().health -= damage;
        }
        Instantiate(destroyEffect, transform.position, transform.rotation);
        Destroy(gameObject);

    }
}
