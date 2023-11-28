using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int totalScore;
    public static int lives = 3;
    public List <GameObject> targets;
    public Button restartButton;
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public EnemySpawnManager enemySpawnManager;
    public MoveEnemyLeft moveEnemyLeft;
    public MoveLeft moveLeft;
    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        titleScreen.gameObject.SetActive(true);


    }

    public void AddLives(int livesToRemove)
    {
        //managing lives
        lives += livesToRemove;
        if (lives <= 0)
        {
            gameOverScreen.gameObject.SetActive(true);
            titleScreen.gameObject.SetActive(false);
            Debug.Log("Game Over");
            lives = 0;
            

        }
        Debug.Log("Lives = " + lives);
    }

    public void UpdateScore(int scoreToAdd)
    {
        totalScore += scoreToAdd;
        scoreText.text = "Score: " + totalScore;
    }

    public void StartGame(int difficulty)
    {
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
        enemySpawnManager.SpawnEnemy();
        totalScore = 0;
        UpdateScore(0);

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverScreen.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

    }
}