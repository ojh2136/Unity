using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{

    public static Spawn instance = null;

    [SerializeField]
    GameObject[] obstacles;

    [SerializeField]
    Transform spawnPoint;

    [SerializeField]
    float spawnRate = 2f;
    float nextSpawn;

    [SerializeField]
    float timeToBoost = 5f;
    float nextBoost;


    public static bool gameStopped;


    // Use this for initialization
    void Start()
    {

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

      
        gameStopped = false;
        Time.timeScale = 1f;
        nextSpawn = Time.time + spawnRate;
        nextBoost = Time.unscaledTime + timeToBoost;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
            SpawnObstacle();

        if (Time.unscaledTime > nextBoost && !gameStopped)
            BoostTime();
    }



    void SpawnObstacle()
    {
        nextSpawn = Time.time + spawnRate;
        int randomObstacle = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[randomObstacle], spawnPoint.position, Quaternion.identity);

    }

    void BoostTime()
    {
        nextBoost = Time.unscaledTime + timeToBoost;
        Time.timeScale += 0.25f;
    }


    public void RestartGame()
    {
        SceneManager.LoadScene("Scene01");
    }

}
