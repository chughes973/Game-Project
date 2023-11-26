using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    private Rigidbody targetRb;
    public GameManager gameManager;
    public int pointValue;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

  
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other) //destroys PowerUp / Pumpkin when collided with Player.
    {
        if (other.CompareTag("Enemy"))
        {
            gameManager.UpdateScore(10); //score is increased by 10 and game object is destroyed  
            Destroy(other.gameObject); //makes enemy disappear

        }
    }
}