using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class EnemyHit : MonoBehaviour
{
    private Rigidbody targetRb;
    public GameManager gameManager;
    
    public GameObject enemyPrefab;
    public AudioSource playerAudio;
    public AudioClip enemyKilled;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other) //destroys obstacles when collided with projectile.
    {
        if (other.CompareTag("Enemy"))
        {
            GameManager.totalScore += 10;//score is increased by 10 and game object is destroyed  
            Destroy(other.gameObject); //destroys projectile
            //Destroy(enemyPrefab);//destroys enemy when hit
        }
    }

    /*public void DestroyTarget(Collider other)
    {

        if (CompareTag("Enemy"))
        {
            Destroy(enemyPrefab);//destroys enemy when hit - need to change to be death animation and then destroy in next iteration
            playerAudio.PlayOneShot(enemyKilled, 1.0f); //shot impact sound plays when projectile interacts with enemy


        }

    }*/

}
