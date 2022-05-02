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
            if (Input.touchCount > 0)     //Here, the character moves to the right or left with the movement of the user's finger.
            {
                parmak = Input.GetTouch(0);
                if (parmak.phase == TouchPhase.Moved)
                {
                    transform.position = new Vector3(transform.position.x + (parmak.deltaPosition.x) / 1000, transform.position.y, transform.position.z);
                }
            }
            transform.Translate(0, 0, hiz * Time.deltaTime);

        }

        else if (stopcube == 1) // When we come to the finish line, we stop our movement and paint the wall.
        {
            transform.Translate(0, 0, 0);
            animator.SetTrigger("Duvar");
            Painting();
        }
        if (transform.position.y < 0) //If the character moves down the y-axis, the game restarts.
        {
            SceneManager.LoadScene("StartScene");
        }

    }

    public void Painting()
    {

        parmak = Input.GetTouch(0);

        if (parmak.phase == TouchPhase.Moved)                                    // Painting is compliting here. Coloring specifically could not be achieved because rend.sharedMaterial.mainTexture is constantly returning null.
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
        if (collision.other.tag == "Obstacle")  //If user hit any obstacle game start again.
        {
            SceneManager.LoadScene(1);
        }
         if (collision.other.name == "Cube")    // if user hit the invisible cube, the all AIs will be destroyed and the user will start painting.
            {
                stopcube = 1;
                for (int i = 0; i <= AiPlayers.Length; i++)
                {
                    Destroy(AiPlayers[i]);
                }

            }

        
    }
}
