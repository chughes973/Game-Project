using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpObtained : MonoBehaviour
{
    public GameObject prefabToDestroy; //assign the prefab to destroy, in this case it's the powerup


    void OnTriggerEnter(Collider other) //destroys obstacles when collided with projectile.
    {
        if (other.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject);
            ScoreManager.totalScore += 1; //score is increased by 1 and game object is destroyed  
        }
    }

}



