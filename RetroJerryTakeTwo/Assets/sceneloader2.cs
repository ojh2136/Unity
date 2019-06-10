using System.Collections;
using UnityEngine;

public class sceneloader2 : MonoBehaviour
{
    public GameObject cat;
    //  public GameObject cat2;
    //  public GameObject cat3;
    //
    float moveSpeed = -5f;
    public float maxPos = 8.02f;
    public float delayTimer = 1f;
    float timer;

    // Use this for initialization
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 catPos = new Vector2(transform.position.x + (moveSpeed * Time.deltaTime), transform.position.y);


            Instantiate(cat, catPos, transform.rotation);
            //      Instantiate (cat2, catPos, transform.rotation);
            //      Instantiate (cat3, catPos, transform.rotation);
            timer = delayTimer;
        }
    }
}