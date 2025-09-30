using UnityEngine;

public class TargetDestroyer : MonoBehaviour
{
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            gameManager.TargetDestroyed();
            Destroy(gameObject);
        }

    }
}
