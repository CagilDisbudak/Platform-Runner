using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    public Renderer Rend;
    void Start()
    {      
    }

    void Update()
    {
    }


    //The scripts for buttons to back to main menu.

    public void MainMenu() 
    {
        Rend.sharedMaterial.color = Color.white;
        SceneManager.LoadScene(0);
    }

}
