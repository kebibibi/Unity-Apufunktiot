using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public Transform target;

    public float speed;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 targetPos = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, targetPos, speed);
        transform.position = smoothPos;

        transform.LookAt(target);
    }
}
