using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WalkiingDragingPainting : MonoBehaviour
{
    private int stopcube = 0;
    public Animator animator;
    Touch parmak;
    public GameObject[] AiPlayers;
    public Button Button;
    public Camera cam;
    void Start()
    {
        Button.gameObject.SetActive(false);
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
        if (transform.position.y < 0)
        {
            SceneManager.LoadScene("StartScene");
        }

    }

    public void Painting()
    {

        parmak = Input.GetTouch(0);

        if (parmak.phase == TouchPhase.Moved)
        {

            RaycastHit hit;
            if (!Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit))
                return;
            if (hit.transform.tag == "Paint")
            {
                Renderer rend = hit.transform.GetComponent<Renderer>();
                rend.sharedMaterial.color = Color.red;
                Button.gameObject.SetActive(true);
                //MeshCollider meshCollider = hit.collider as MeshCollider;

                //if (rend == null || rend.sharedMaterial == null || rend.sharedMaterial.mainTexture == null || meshCollider == null)
                //    return;

                //Texture2D tex = rend.material.mainTexture as Texture2D;
                //Vector2 pixelUV = hit.textureCoord;
                //pixelUV.x *= tex.width;
                //pixelUV.y *= tex.height;

                //tex.SetPixel((int)pixelUV.x, (int)pixelUV.y, Color.red);
                //tex.Apply();
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
            for (int i = 0; i <= AiPlayers.Length; i++)
            {
                Destroy(AiPlayers[i]);
            }

        }

    }
}
