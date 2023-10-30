using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other) //destroys obstacles when collided with projectile.
    {
        if (other.CompareTag("Obstacle"))
        {

            Destroy(gameObject);
            Destroy(other.gameObject);
            ScoreManager.totalScore += 1; //score is increased by 1 and game object is destroyed  
        }
    }
    
}