using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{

    public static bool GameisPaused = false;

    public GameObject pausemenuUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Debug.Log("Pressed Esc");
                ResumeResume();
            }
            else
            {
                Debug.Log("Pressed Esc");
                PausePause();
            }
        }
    }


    public void ResumeResume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    void PausePause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void Loadmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        GameisPaused = false;
    }

    public void Quitgame()
    {
        Debug.Log("Quit Game");
        Application.Quit();

    }

}
