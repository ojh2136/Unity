using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScenePlatformer : MonoBehaviour {


     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Jerry")
        {
            //The scene number to load (in File->Build Settings)
            Time.timeScale = 1f;
            SceneManager.LoadScene("InstructionLevelFinal");
        }
    }
}

