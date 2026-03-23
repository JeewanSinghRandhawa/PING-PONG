using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;
    public Ball ball;

    int p1Score = 0;
    int p2Score = 0;

    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        p1ScoreText.text = p1Score.ToString();
        p2ScoreText.text = p2Score.ToString();
    }

    void CheckWin()
    {
        if (p1Score >= 5)
        {
            Debug.Log("Player 1 Wins!");
            ResetGame();
        }
        else if (p2Score >= 5)
        {
            Debug.Log("Player 2 Wins!");
            ResetGame();
        }
    }

    void ResetGame()
    {
        p1Score = 0;
        p2Score = 0;
        UpdateUI();
        ball.ResetBall();
    }

    public void P1Scored()
    {
        p1Score++;
        UpdateUI();
        ball.ResetBall();
        CheckWin();
    }

    public void P2Scored()
    {
        p2Score++;
        UpdateUI();
        ball.ResetBall();
        CheckWin();
    }
}