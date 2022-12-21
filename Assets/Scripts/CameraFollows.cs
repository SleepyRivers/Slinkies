using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float damping; 

    private Vector3 Velocity = Vector3.zero;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 movePosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref Velocity, damping);
    }
}
