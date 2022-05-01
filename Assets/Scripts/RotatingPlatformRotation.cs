using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatformRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int RotationRatio;

    void Update()
    {
        transform.Rotate(Vector3.forward * RotationRatio * Time.deltaTime, Space.Self);

    }
}
