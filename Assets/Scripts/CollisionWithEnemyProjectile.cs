using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithEnemyProjectile : MonoBehaviour
{
    private Rigidbody targetRb;
    public GameManager gameManager;

    public int pointValue;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //gameManager.UpdateScore(10); //score is increased by 10 and game object is destroyed  
            Destroy(gameObject);
        }
    }
}
