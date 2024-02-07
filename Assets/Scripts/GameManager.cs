using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI[] Text;
    public GameObject gameOverPanel;
    private void Awake()
    {
        instance = this;
    }
    public int score = 0,lives = 5;
    bool gameOver = false;

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            Text[1].text = score.ToString();

        }
    
    }
    
    public void Lifecount()
    {
        if (lives > 0)
        {
            lives--;
            Text[0].text = lives.ToString();
        }
        if(lives <= 0 ) {
            GameOver();
        }
    }

    public void GameOver()
    {
        spawnManager.Instance.StopSpawning();
        Text[0].text = "0";
        gameOver = true;
        gameOverPanel.SetActive(true);
        Text[2].text = "Score:" + score.ToString();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
    }

    private void Start()
    {
        Text[0].text = lives.ToString();
    }

    public void restart() 
    {
        SceneManager.LoadScene("GameScene");
    }

    public void menuLoader()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
