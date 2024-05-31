using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Takip edilecek obje
    public Vector3 offset;    // Kameranýn hedefe göre ofseti
    public float smoothSpeed = 0.125f;  // Kameranýn hareketini yumuþatma hýzý

    void LateUpdate()
    {
        // Hedef pozisyonu hesapla
        Vector3 desiredPosition = target.position + offset;

        // Kameranýn pozisyonunu yumuþat
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Kameranýn hedefe bakmasýný saðla
        transform.LookAt(target);
    }
}
