using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTarget : MonoBehaviour
{
    private Rigidbody targetRb;
    private GameManager gameManager;
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
    public void DestroyTarget()
    {

        if (CompareTag("Enemy"))
        {
            Destroy(gameObject); //makes powerup disappear
            gameManager.UpdateScore(5);//score is increased by 1 and game object is destroyed  


        }

    }
}