using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public GameObject GameManager;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnBack()
    {
        GameManager.SendMessage("Continue");
    }

    public void OnRestart()
    {
        Time.timeScale = 1F;
        SceneManager.LoadScene("Main");
    }

    public void OnReturn()
    {
        Time.timeScale = 1F;
        SceneManager.LoadScene("Title");
    }
}
