using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowing : MonoBehaviour
{
    public Transform[] target;
    public float speed;
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


        if (transform.position.y < 0) 
        {
            transform.position = FirstPos;
            current = 0;
        }

        min = 10;
        

        for (int i = 0; i <= (target[current].childCount) - 1; i++)
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

        if (transform.position.z != target[current].GetChild(last).transform.position.z)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].GetChild(last).transform.position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
            Debug.Log("Current : " + current);
            if (target[current].GetChild(last).transform.position.z - transform.position.z < 0.1)
            {
                current = (current + 1);
                Debug.Log("Current : "  + current);
            }
           
        }
        else
        {
            current = (current + 1);
        }
    }
}