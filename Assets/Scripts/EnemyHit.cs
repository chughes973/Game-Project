using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyHit : MonoBehaviour
{
    private Rigidbody targetRb;
    private GameManager gameManager;
    
    public GameObject enemyPrefab;
    public AudioSource playerAudio;
    public AudioClip enemyKilled;

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
            Destroy(enemyPrefab);//destroys enemy when hit - need to change to be death animation and then destroy in next iteration
            playerAudio.PlayOneShot(enemyKilled, 1.0f); //shot impact sound plays when projectile interacts with enemy
            gameManager.UpdateScore(10);//score is increased by 10 and game object is destroyed  


        }

    }

}
