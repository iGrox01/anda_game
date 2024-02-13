using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public Transform target; // The target object to follow (usually the player)
    public float smoothSpeed = 0.125f; // How smoothly the camera catches up to its target
    public Vector3 offset; // Offset from the target object

    void Update()
    {
        // Target position with offset
        Vector3 desiredPosition = target.position + offset;
        // Interpolated position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        // Update camera position
        transform.position = smoothedPosition;

        // Optional: Make the camera always look at the target
        // transform.LookAt(target);
    }
}
