using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManeger : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        InvokeRepeating("SpawnBallWave", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        SpawnBallWave();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(10, 40);
        float spawnPosY = Random.Range(2, 9);
        Vector3 randomPosition = new Vector3(spawnPosX, spawnPosY, 1);
        return randomPosition;
    }

    void SpawnBallWave()
    {
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(ballPrefab, GenerateSpawnPosition(), ballPrefab.transform.rotation);
        }
    }

}

