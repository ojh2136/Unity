using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
        //other.name should equal the root of your Player object
        if (other.name == "Jerry")
        {
            //The scene number to load (in File->Build Settings)
            Time.timeScale = 1f;
            SceneManager.LoadScene("InstructionLevelTwo");
        }
    }


}
