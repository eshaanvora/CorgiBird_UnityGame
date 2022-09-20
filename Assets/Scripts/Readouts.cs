using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Readouts : MonoBehaviour
{
    public Text Score;
    public Text GameResult;

    public void Reset(int score)
    {
        //ShowScore(0);
        HideWinResult();
    }

    public void ShowScore(float score)
    {
        Score.text = "SCORE: " + score;
    }

    public void ShowLoseResult()
    {
        GameResult.text = "GAME OVER";
    }

    public void ShowWinResult()
    {
        GameResult.text = "WIN";
    }

    public void HideWinResult()
    {
        GameResult.text = "";
    }

}