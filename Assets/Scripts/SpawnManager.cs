using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject powerupPrefab;
    private Vector3 spawnPosObs = new Vector3(25, 0, 0);
    private Vector3 spawnPosPU = new Vector3(50, 0, 0);
    private float startDelay = 2.0f;
    private float repeatRate = 2.0f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate); //repeating of obstacle spawn
        InvokeRepeating("SpawnPowerUp", startDelay, repeatRate); //repeating of powerup spawn
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
        //initial spawn of obstacle
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPosObs, obstaclePrefab.transform.rotation); //spawns boxes
        }

    }

    void SpawnPowerUp()
    {
        //initial spawn of powerup
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(powerupPrefab, spawnPosPU, powerupPrefab.transform.rotation); //spawns powerup pumpkins
        }
    }
}
