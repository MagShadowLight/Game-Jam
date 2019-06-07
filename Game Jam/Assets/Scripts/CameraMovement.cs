using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform tr;

    public float SmoothSpeed = 0.125f;
    public Vector3 offset;

    

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = tr.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(tr);
    }
}
