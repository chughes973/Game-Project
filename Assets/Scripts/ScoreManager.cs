using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int totalScore = 0;


    private void Start()
    {

    }

    private void OnGUI()
    {
        //creates a scoreboard
        GUI.Box(new Rect(100, 100, 200, 100), "Score : " + totalScore.ToString()); //scoreboard 
    }

}