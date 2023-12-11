using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //variables
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public static int totalScore;
    public static int lives;
    public List <GameObject> targets;
    public Button restartButton;
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public GameObject goalScreen;
    public EnemySpawnManager enemySpawnManager;
    public MoveEnemyLeft moveEnemyLeft;
    public MoveLeft moveLeft;
    public bool isGameActive;
    public bool goalScore;

    // Start is called before the first frame update
    void Start()
    {
        titleScreen.gameObject.SetActive(true);
        lives = 3;
        livesText.text = "Lives: " + lives;

        totalScore = 0;
        scoreText.text = "Score: " + totalScore;
        goalScore = false;

    }

    public void UpdateLives(int livesToRemove)
    {
        //managing lives
        lives -= livesToRemove;
        livesText.text = "Lives: " + lives;

        if (lives <= 0)
        {
            GameOver();


        }
        Debug.Log("Lives = " + lives);


    }

    public void UpdateScore(int scoreToAdd)
    {
        //score manager
        totalScore += scoreToAdd;
        scoreText.text = "Score: " + totalScore;
        if (totalScore == 100)
        {
            goalScore  = true;
            goalScreen.gameObject.SetActive(true);
            LevelTwo();


        }
    }

    public void StartGame(int difficulty)
    {
        //will run when start button is pressed
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
        enemySpawnManager.SpawnEnemy();
        totalScore = 0;
        UpdateScore(0);
        UpdateLives(0);

    }

    public void RestartGame()
    {
        // will run when restart button is pressed
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        //activates when player collides with obstacle 
        isGameActive = false;
        gameOverScreen.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

    }

    public void LevelTwo()
    {

    }
}