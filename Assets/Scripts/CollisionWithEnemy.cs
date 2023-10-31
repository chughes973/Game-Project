using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithEnemy : MonoBehaviour
{

    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            //destroys enemy when hit - need to change to be death animation and then destroy in next iteration
            ScoreManager.lives -= 1; //lives is decreased by 1 and enemy is destroyed  
        }
    }*/

    void OnTriggerEnter(Collider other) //destroys obstacles when collided with projectile.
    {
        if (other.CompareTag("Enemy"))
        {

            Destroy(gameObject); //destroys player
            ScoreManager.lives+= 1;
        }
    }
}
