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
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        InvokeRepeating("SpawnPowerUp", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
        //repeats spawning of obstacle 
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPosObs, obstaclePrefab.transform.rotation);
        }

    }

    void SpawnPowerUp()
    {
        //repeats spawning of powerups as long as game isn't over
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(powerupPrefab, spawnPosPU, powerupPrefab.transform.rotation);
        }
    }
}
