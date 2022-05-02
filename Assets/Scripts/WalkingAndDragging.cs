//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class WalkingAndDragging : MonoBehaviour
//{
//    private int stopcube = 0;
//    public Animator animator;
//    Touch parmak;
//    public GameObject[] AiPlayers;
//    public Texture2D splashTexture;
//    public GameObject Brush;
//    public float BrushSize = 1f;
//    void Start()
//    {
        
//    }
//    public int hiz;
 

//    void Update()
//    {
//        if (stopcube == 0)
//        {
//            if (Input.touchCount > 0)
//            {
//                parmak = Input.GetTouch(0);
//                if (parmak.phase == TouchPhase.Moved)
//                {
//                    transform.position = new Vector3(transform.position.x + (parmak.deltaPosition.x) / 1000, transform.position.y, transform.position.z);
//                }
//            }
//            transform.Translate(0, 0, hiz * Time.deltaTime);
//            Debug.Log("Yuruyor");
//        }
//        else if (stopcube == 1)
//        {
//            transform.Translate(0, 0, 0);
//            animator.SetTrigger("Duvar");
//            Debug.Log("Durdu");
//            Painting();
//        }
//        if (transform.position.y < 0)
//        {
//            SceneManager.LoadScene("StartScene");
//        }

//    }

//    public void Painting() 
//    {

//        parmak = Input.GetTouch(0);
//        //if (parmak.phase == TouchPhase.Moved)
//        //{
//        //    var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//        //    RaycastHit hit;
//        //    if (Physics.Raycast(Ray, out hit, 1000.0f))
//        //    {
//        //        if (hit.transform.tag == "Paint")
//        //        {
//        //            var go = Instantiate(Brush, hit.point + Vector3.right * 0.1f, Quaternion.identity, transform);
//        //            go.transform.localScale = Vector3.one * BrushSize;
//        //            go.transform.Rotate(-90.0f, 0.0f, 0.0f, Space.Self);
//        //        }
//        //    }
//        //}

//        if (parmak.phase == TouchPhase.Moved)
//        {
//            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//            RaycastHit hit;
//            if (Physics.Raycast(Ray, out hit, 1000.0f))
//            {
//                if (hit.transform.tag == "Paint")
//                {
//                    var go = Instantiate(Brush, hit.point + Vector3.right * 0.1f, Quaternion.identity, transform);
//                    go.transform.localScale = Vector3.one * BrushSize;
//                    go.transform.Rotate(-90.0f, 0.0f, 0.0f, Space.Self);

//                    ////PaintOn(hit.textureCoord);
//                }
//            }
//        }

//    }

//    //public void PaintOn(Vector2 textureCoord)
//    //{
//    //    m_texture = new Texture2D(textureWidth, textureHeight);
//    //    for (int xcor = 0; xcor < textureWidth; xcor++)
//    //        for (int ycor = 0; ycor < textureHeight; ycor++)
//    //            m_texture.SetPixel(xcor, ycor, Color.red);
//    //    m_texture.Apply();

//    // //   if (isEnabled)
//    // //   {
//    //        int x = (int)(textureCoord.x * textureWidth) - (splashTexture.width / 2);
//    //        int y = (int)(textureCoord.y * textureHeight) - (splashTexture.height / 2);
//    //        //for (int i = 0; i < splashTexture.width; ++i)
//    //        //    for (int j = 0; j  0)
//    //        //    {
//    //        //        Color result = Color.Lerp(existingColor, targetColor, alpha);   // resulting color is an addition of splash texture to the texture based on alpha
//    //        //        result.a = existingColor.a + alpha;                             // but resulting alpha is a sum of alphas (adding transparent color should not make base color more transparent)
//    //        //        m_texture.SetPixel(newX, newY, result);
//    //        //    }
//    // //   }

//    //    m_texture.Apply();
//    //}


//    [System.Obsolete]
//    private void OnCollisionEnter(Collision collision)
//    {
//        if (collision.other.name == "Cube")
//        {
//            stopcube = 1;
//            Debug.Log("Cube Girdi");
//            for (int i = 0; i <= AiPlayers.Length; i++)
//            {
//                Destroy(AiPlayers[i]);
//            }

//        }
       
//    }
//}
