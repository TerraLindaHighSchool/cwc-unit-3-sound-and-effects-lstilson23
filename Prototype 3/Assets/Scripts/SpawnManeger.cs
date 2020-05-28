using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManeger : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject powerUpPrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    //private Vector3 powerUpPos = new Vector3(Random.Range(10, 40), Random.Range(2, 9), 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
    /*
    void SpawnPowerUp()
    {
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(powerUpPrefab, powerUpPos, powerUpPrefab.transform.rotation);
        }

    }
    */
}

