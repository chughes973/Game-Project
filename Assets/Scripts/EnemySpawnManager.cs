using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private PlayerController playerControllerScript;
    private EnemySpawnManager spawnEnemyManagerScript;
    private Vector3 spawnPosEnemy = new Vector3(30, 0, 0);
    private float startDelay = 2.0f;
    private float repeatRate = 20f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, repeatRate) ;
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();


    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnEnemy()
    {
        SpawnEnemyCoroutine();
        Instantiate(enemyPrefab, spawnPosEnemy, enemyPrefab.transform.rotation); //spawns skeletons
                playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    IEnumerator SpawnEnemyCoroutine()
    {
        yield return new WaitForSeconds(startDelay);
        SpawnEnemy();
    }

}
