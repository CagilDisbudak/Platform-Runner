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

    // Update is called once per frame
    void Update()
    {
        
    }
    [System.Obsolete]
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
