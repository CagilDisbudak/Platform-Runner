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

    // Update is called once per frame
    void Update()
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
