using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quefollow : MonoBehaviour
{
    public GameObject[] Players;
    private float zCoord;
    void Start()
    {
        zCoord = Players[0].transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= Players.Length ; i++) 
        {
            if (Players[i].transform.position.x > zCoord)
            { 
                zCoord = Players[i].transform.position.z;   
            }
        }
    }
}
