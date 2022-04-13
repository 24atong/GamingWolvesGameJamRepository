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
<<<<<<< HEAD
       SceneManager.LoadScene(1);
        
=======
        completeLevelUI.SetActive(true);
>>>>>>> parent of c06f2d5 (added sound :))
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
