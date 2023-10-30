using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpObtained : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) //destroys obstacles when collided with.
    {
        if (other.CompareTag("Obstacle"))
        {

            Destroy(gameObject);
            Debug.Log("PowerUp!"); //Powerup is consumed and message displayed
            ScoreManager.totalScore += 5; // increases points by 5 if powerup is consumed 
        }
    }
}


