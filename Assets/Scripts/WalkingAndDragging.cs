using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingAndDragging : MonoBehaviour
{
    private int stopcube = 0;
    public Animator animator;
    Touch parmak;
    public GameObject[] AiPlayers;

    public GameObject Brush;
    public float BrushSize = 1f;

    void Start()
    {
        
    }
    public int hiz;

    void Update()
    {
        if (stopcube == 0)
        {
            if (Input.touchCount > 0)
            {
                parmak = Input.GetTouch(0);
                if (parmak.phase == TouchPhase.Moved)
                {
                    transform.position = new Vector3(transform.position.x + (parmak.deltaPosition.x) / 1000, transform.position.y, transform.position.z);
                }
            }
            transform.Translate(0, 0, hiz * Time.deltaTime);
            Debug.Log("Yuruyor");
        }
        else if (stopcube == 1)
        {
            transform.Translate(0, 0, 0);
            animator.SetTrigger("Duvar");
            Debug.Log("Durdu");
            Painting();
        }


    }

    public void Painting() 
    {

        parmak = Input.GetTouch(0);
        if (parmak.phase == TouchPhase.Moved)
        {
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit, 100))
            {
                if (hit.transform.tag == "Paint")
                {
                    var go = Instantiate(Brush, hit.point + Vector3.right * 0.1f, Quaternion.identity, transform);
                    go.transform.localScale = Vector3.one * BrushSize;
                    go.transform.Rotate(-90.0f, 0.0f, 0.0f, Space.Self);
                }
            }
        }

    }


 

    [System.Obsolete]
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.name == "Cube")
        {
            stopcube = 1;
            Debug.Log("Cube Girdi");
           
        }
        for (int i = 0; i <= AiPlayers.Length; i++)
        {
            Destroy(AiPlayers[i]);
        }
    }
}
