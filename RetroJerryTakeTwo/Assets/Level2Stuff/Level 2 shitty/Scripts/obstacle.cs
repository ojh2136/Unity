using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    [SerializeField]
    float moveSpeed = -5f;

     void Update()
    {
    

            transform.position = new Vector2(transform.position.x + (moveSpeed * Time.deltaTime), transform.position.y);

            if (transform.position.x < -13f)
                Destroy(gameObject);
        

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            other.GetComponent<jump>().health -= damage;
            Debug.Log(other.GetComponent<jump>().health -= damage);
            Destroy(gameObject);
        }
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
