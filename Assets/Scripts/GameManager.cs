using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
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
        }
    
    }

    public void Lifecount()
    {
        lives--;
        if (lives == 0)
        {
            Debug.Log("You're Dead | Your score is:"+score);
            gameOver = true;
            spawnManager.Instance.StopSpawning();
        }
    }
}
