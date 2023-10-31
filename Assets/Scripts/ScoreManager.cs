using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int totalScore = 0;
    public static int lives = 3;


    private void Start()
    {

    }

    private void OnGUI()
    {
        //creates a scoreboard
        GUI.Box(new Rect(50, 50, 130, 20), "Score : " + totalScore.ToString()); //scoreboard 
        GUI.Box(new Rect(50,80, 130, 20), "Lives:" + lives.ToString()); //livesboard
    }

}