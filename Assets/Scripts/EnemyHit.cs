using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public AudioSource playerAudio;
    public AudioClip enemyKilled;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) //destroys obstacles when collided with projectile.
    {
        if (other.CompareTag("Enemy"))
        {

            Destroy(gameObject); //destroys projectile
            Destroy(other.gameObject);//destroys enemy when hit - need to change to be death animation and then destroy in next iteration
            playerAudio.PlayOneShot(enemyKilled, 1.0f); //shot impact sound plays when projectile interacts with enemy
            ScoreManager.totalScore += 10; //score is increased by 1 and game object is destroyed  

        }
    }
}
