using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quefollow : MonoBehaviour
{
    public GameObject[] Players;
    public Text text;
    private int say = 1;
    void Start()
    {
    }

   
    void Update()                              //By looking at the z-coordinate of all the characters, it is found boy's location.
    {
       
        say = 1;
        for (int i = 1; i <= Players.Length; i++)
        {
          
            if (Players[i].transform.position.z > Players[0].transform.position.z)
            {
                say++;
            }
            text.text = say + ". " + Players[0].name;
        }
    
    }

}

