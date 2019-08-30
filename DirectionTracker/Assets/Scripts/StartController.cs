using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public GameObject startButton;
    public GameObject helpButton;
    public GameObject exitButton;

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void ShowHelp()
    {
        SceneManager.LoadScene("Help");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
