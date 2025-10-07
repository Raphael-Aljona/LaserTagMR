using UnityEngine;

public class TargetDestroyer : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            gameManager.TargetDestroyed();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

    }
}
