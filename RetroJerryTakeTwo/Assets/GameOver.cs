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

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameover.SetActive(false);

       
    }

    public void gameended ()
    {
        gameover.SetActive(true);
    }

    public void gameendedWin()
    {
        gamewin.SetActive(true);
    }

    public void restartOne()
    {
        SceneManager.LoadScene("EndScreen");
        gamewin.SetActive(false);
        gameHasEnded = false;
    }
}
