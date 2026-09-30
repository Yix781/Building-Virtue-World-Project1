using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform xrOrigin;
    public Transform xrCamera;
    public Transform destination;

    public void Teleport()
    {
        Vector3 cameraOffset = xrCamera.position - xrOrigin.position;
        cameraOffset.y = 0;

        xrOrigin.position = destination.position - cameraOffset;
    }
}