﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoveLevel2 : MonoBehaviour {
    float timeToBoost = 5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * timeToBoost * Time.deltaTime);
    }
}
