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

    // Start is called before the first frame update
    void Start()
    {
        totalScore = 0;
        UpdateScore(0);
    }

    public void AddLives(int value)
    {
        //managing lives
        lives += value;
        if (lives <= 0)
        {
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

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}