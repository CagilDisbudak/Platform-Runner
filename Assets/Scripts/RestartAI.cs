using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartAI : MonoBehaviour
{
    public GameObject RestartPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "AI") 
        {
            collision.transform.Translate(RestartPoint.transform.position, Space.World);
        }
    }

}
