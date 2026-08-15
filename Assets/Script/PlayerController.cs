using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] private float speed = 5.0f;
    Vector2 movementInput;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }


    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }

    void FixedUpdate()
    {
        playerRb.AddTorque(new Vector3(movementInput.y, 0, -movementInput.x) * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.GetComponent<Coin>().collectCoin();
            
        } else if (other.gameObject.CompareTag("enemy"))
        {
            other.gameObject.GetComponent<GameManager>().GameOver();
        }
    }
}
