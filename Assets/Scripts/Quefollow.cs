using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quefollow : MonoBehaviour
{
    public GameObject[] Players;
    private float zCoord;
    public Text text;
    void Start()
    {
        zCoord = Players[0].transform.position.z;

    }

   
    void Update()                              //By looking at the z-coordinate of all the characters, it is found out who is ahead.
    {
        for (int i = 0; i <= Players.Length ; i++) 
        {
            if (Players[i].transform.position.z > zCoord)
            { 
                zCoord = Players[i].transform.position.z;
                text.text = "1. " + Players[i].name;
            }
        }
    }
}
