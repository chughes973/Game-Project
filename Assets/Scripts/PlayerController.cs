using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public AudioSource playerAudio;
    public GameObject projectilePrefab;
    public GameManager gameManager;
    public TextMeshProUGUI gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier; //allows player to adjust the gravity 
        playerAudio = GetComponent<AudioSource>(); //enables audio to play 
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        //&& !gameOver stops the player from being able to jump when unconscious
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            //Launch projectile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) //hitting space makes player jump and stops player jumping while unconscious
        {
            playerRb.AddForce(Vector3.up * 17, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f); //plays jump sound when player presses space bar 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true; //prevents player double jumping
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!"); //Game Over is triggered when player collides with obstacle
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f); //this audio keeps disabling? Unsure why but will work on this following alpha submission 
            GameOver();

        }

    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);

    }


}