using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpObtained : MonoBehaviour
{
    public GameObject prefabToDestroy; //assign the prefab to destroy, in this case it's the powerup
    public AudioSource playerAudio;
    public AudioClip powerupConsume;


    void OnTriggerEnter(Collider other) //destroys PowerUp / Pumpkin when collided with Player.
    {
        if (other.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject); //makes powerup disappear
            playerAudio.PlayOneShot(powerupConsume, 1.0f); //eating sound plays when player collides with powerup
            ScoreManager.totalScore += 5; //score is increased by 1 and game object is destroyed  
            
        }
    }

}



