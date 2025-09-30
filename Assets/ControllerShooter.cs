using UnityEngine;
using UnityEngine.InputSystem;
public class ControllerShooter : MonoBehaviour
{
    public InputActionProperty triggerAction; // Conecte no inspector a ação do trigger
    public Transform shootOrigin;
    public GameObject projectilePrefab;
    public float shootForce = 10f;
    public float laserLength = 5f;

    private LineRenderer lineRenderer;
    private bool triggerPressedLastFrame = false;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
    }

    void Update()
    {
        UpdateLaser();

        float triggerValue = triggerAction.action.ReadValue<float>();

        if (triggerValue > 0.1f)
        {
            if (!triggerPressedLastFrame)
            {
                Shoot();
                triggerPressedLastFrame = true;
            }
        }
        else
        {
            triggerPressedLastFrame = false;
        }
    }

    void UpdateLaser()
    {
        if (shootOrigin != null)
        {
            Vector3 start = shootOrigin.position;
            Vector3 end = start + shootOrigin.forward * laserLength;

            lineRenderer.SetPosition(0, start);
            lineRenderer.SetPosition(1, end);
        }
    }

    void Shoot()
    {
        if (projectilePrefab == null || shootOrigin == null) return;

        GameObject projectile = Instantiate(projectilePrefab, shootOrigin.position, shootOrigin.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.linearVelocity = shootOrigin.forward * shootForce;
        }
    }
}   