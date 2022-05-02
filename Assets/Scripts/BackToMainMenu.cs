using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update\
    public Renderer Rend;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenu() 
    {
        Rend.sharedMaterial.color = Color.white;
        SceneManager.LoadScene(1);
    }

}
