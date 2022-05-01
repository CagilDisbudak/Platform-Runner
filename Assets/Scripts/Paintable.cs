using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintable : MonoBehaviour
{
    public GameObject Brush;
    public float BrushSize = 1f;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       // parmak = Input.GetTouch(0);
        if (Input.GetMouseButton(0)) 
        {
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit,100))
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
}
