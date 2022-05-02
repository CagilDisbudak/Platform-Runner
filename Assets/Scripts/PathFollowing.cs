using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PathFollowing : MonoBehaviour
{
    public Transform[] target;
    private float speed = 2.5f;
    private int current;
    private float min;
    private float min1;
    private int last;
    private Vector3 FirstPos;
    void Start()
    {
        FirstPos = transform.position;  
        current = 0;
    }


    void Update()
    {


        if (transform.position.y < 0)                     // If the ai moves in the y-direction, it returns to the starting point.
        {
            transform.position = FirstPos;
            current = 0;
        }

        min = 10;
        

        for (int i = 0; i <= (target[current].childCount) - 1; i++)                          // In this step, when choosing the next path to go, we choose the one closest to ourselves.               
        {
            if (target[current].GetChild(i).transform.position.x - transform.position.x < 0)
            {

                min1 = -1 * (target[current].GetChild(i).transform.position.x - transform.position.x);

            }
            else
            {
                min1 = (target[current].GetChild(i).transform.position.x - transform.position.x);
            }

            if (min1 < min)
            {
                min = min1;
                last = i;
            }

        }

        if (transform.position.z != target[current].GetChild(last).transform.position.z) // If we have not arrived at your destination, enter the if statement.
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].GetChild(last).transform.position, speed * Time.deltaTime);    // starts the movement to the destination.
            GetComponent<Rigidbody>().MovePosition(pos);
            if (target[current].GetChild(last).transform.position.z - transform.position.z < 0.1)
            {
                current = (current + 1);
            }
           
        }
        else
        {
            current = (current + 1);
        }
    }

    [System.Obsolete]
    private void OnCollisionEnter(Collision collision)   //if ai hit the obstacle it will start from begining.
    {
        if (collision.other.tag == "Obstacle")
        {
            transform.position = FirstPos;
            current = 0;
        }
    }
 }