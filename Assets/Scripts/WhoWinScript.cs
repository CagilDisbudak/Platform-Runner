using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhoWinScript : MonoBehaviour
{
    public GameObject[] AiPlayers;
    public Animator Win;
    public Animator Lose;
    public int first;
    public Camera cam;
    Touch parmak;
    void Start()
    {
        first = 0;
    }
    void Update()
    { 
    }


    [System.Obsolete]



    //Plays the Animation showing whether the user or the Ai won.

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.tag == "AI")
        {
            first = 1;
            Lose.SetTrigger("Lose");

        }
        else if (collision.other.name == "Boy")
        {
            first = 2;
            Win.SetTrigger("Win");
        }

    }
    public int First() 
    {
        return first;
    }

}
