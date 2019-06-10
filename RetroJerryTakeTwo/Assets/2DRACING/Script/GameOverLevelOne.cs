using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverLevelOne : MonoBehaviour {
    public GameObject gameover;
    bool gameHasEnded = false;
    public float delay = 2f;

    // end game lost
    public void EndGame()
    {
        if (gameHasEnded == false)
        {

            gameHasEnded = true;
            Debug.Log("U DEAD");
            gameended();
            Invoke("Restart", delay);

        }

    }
    //restart scene
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameover.SetActive(false);
       


    }
    // making screen visible
    public void gameended()
    {
        gameover.SetActive(true);

    }
}
