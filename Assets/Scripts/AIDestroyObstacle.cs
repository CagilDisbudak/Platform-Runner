using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDestroyObstacle : MonoBehaviour
{
 
    void Start()
    {}

    void Update()
    {}


    // When AI hith the obstacle they will destroyed.

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "AI")
        {
            Destroy(collision.gameObject);
        }
    }
}
