using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    private void Awake()
    {
        instance = this;
    }
    public int score = 0,lives = 4;
    bool gameOver = false;

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();

        }
    
    }

    public void Lifecount()
    {
        lives--;
        if (lives == 0)
        {
            gameOver = true;
            spawnManager.Instance.StopSpawning();
        }
    }
}
