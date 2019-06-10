using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject projectile;
    public Transform shotPoint;



    // Use this for initialization



    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

	}

    void Shoot ()
    {
        Instantiate(projectile, shotPoint.position, shotPoint.rotation);
    }
}
