using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false;
 
    public float restartDelay = 2f;

    public void CompleteLevel()
    {
       SceneManager.LoadScene(1);
        
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
 
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
