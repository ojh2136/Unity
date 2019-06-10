using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {
    bool gameHasEnded = false;
    public GameObject gameover;
    public GameObject gamewin;
    public float delay = 2f;
    private void Start()
    {
       
    }
    // end game lost
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("U DEAD");
            gameended();
            Invoke("Restart", delay);
        }

    }
    // end game win
    public void EndGameWin()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("U WON");
            gameendedWin();
            Invoke("restartOne", delay);
        }
    }
    // restarting scene
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameover.SetActive(false);

       
    }
    //making screen visible
    public void gameended ()
    {
        gameover.SetActive(true);
    }

    public void gameendedWin()
    {
        gamewin.SetActive(true);
    }
    //restarting for boss scene
    public void restartOne()
    {
        SceneManager.LoadScene("EndScreen");
        gamewin.SetActive(false);
        gameHasEnded = false;
    }
}
