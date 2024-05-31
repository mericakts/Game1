using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Takip edilecek obje
    public Vector3 offset;    // Kameran�n hedefe g�re ofseti
    public float smoothSpeed = 0.125f;  // Kameran�n hareketini yumu�atma h�z�

    void LateUpdate()
    {
        // Hedef pozisyonu hesapla
        Vector3 desiredPosition = target.position + offset;

        // Kameran�n pozisyonunu yumu�at
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Kameran�n hedefe bakmas�n� sa�la
        transform.LookAt(target);
    }
}
