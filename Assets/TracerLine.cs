using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class TracerLine : MonoBehaviour
{
    public Transform controllerTransform; // Mão ou controle do jogador
    public float laserLength = 5f;        // Comprimento do traçante

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
    }

    void Update()
    {
        if (controllerTransform != null)
        {
            Vector3 start = controllerTransform.position;
            Vector3 end = start + controllerTransform.forward * laserLength;

            lineRenderer.SetPosition(0, start);
            lineRenderer.SetPosition(1, end);
        }
    }
}
