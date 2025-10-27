using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;   // the sphere
    public Vector3 offset;     // position offset
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        // Desired position
        Vector3 desiredPosition = target.position + offset;

        // Smooth follow
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Always look at the player
        transform.LookAt(target);
    }
}
