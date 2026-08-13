using UnityEngine;

public class Coin : MonoBehaviour
{

    private Transform coinTransform;
    GameManager gameManager;
    void Start()
    {
        coinTransform = GetComponent<Transform>();
        gameManager = FindAnyObjectByType<GameManager>();
    }

    void Update()
    {
        coinTransform.Rotate(1f, 0f, 0f);
    }

    public void collectCoin()
    {
        
        if (gameManager != null)
        {
            gameManager.AddScore(1);
        }
        Destroy(gameObject);
    }

}
