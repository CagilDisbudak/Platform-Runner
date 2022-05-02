using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatformRotation : MonoBehaviour
{
    void Start()
    {
        
    }
    public int RotationRatio;

    void Update()  //The rotation of the moving platforms is provided here.
    {
        transform.Rotate(Vector3.forward * RotationRatio * Time.deltaTime, Space.Self);

    }
}
