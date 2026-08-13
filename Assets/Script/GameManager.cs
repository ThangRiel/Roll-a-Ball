using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
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
    }
}
