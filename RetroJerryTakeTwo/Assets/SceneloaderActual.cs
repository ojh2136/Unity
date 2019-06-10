 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;


public class SceneLoaderActual : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //other.name should equal the root of your Player object
        if (other.name == "Jerry")
        {
            //The scene number to load (in File->Build Settings)
            SceneManager.LoadScene("Level 3");
        }
    }
}
