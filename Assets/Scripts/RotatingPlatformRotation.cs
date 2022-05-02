using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatformRotation : MonoBehaviour
{
    void Start()
    {
        
    }
    public int RotationRatio;

    void Update()
    {
        transform.Rotate(Vector3.forward * RotationRatio * Time.deltaTime, Space.Self);

    }
}
