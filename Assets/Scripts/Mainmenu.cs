using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    
    public void Playgame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }


    public void Quitgame()
    {
        Debug.Log("QuitMessage");
        Application.Quit();

    }
            
    
}
