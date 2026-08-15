using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameResultText;
    void Start()
    {
        scoreText.text = " Score: 0";
    }

    void Update()
    {
        
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = " Score: " + score.ToString();

        if (score >= 10)
        {
            GameWin();
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameResultText.text = " You Lose! Final Score: " + score.ToString();
    }

    public void GameWin()
    {
        Time.timeScale = 0;
        gameResultText.text = " You Win! Final Score: " + score.ToString();
    }
}
