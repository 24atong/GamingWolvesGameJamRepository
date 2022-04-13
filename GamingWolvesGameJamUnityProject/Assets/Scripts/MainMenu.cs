using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayAgain ()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}

