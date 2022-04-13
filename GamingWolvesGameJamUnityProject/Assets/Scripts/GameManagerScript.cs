using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false;
 
    public float restartDelay = 2f;
    
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
<<<<<<< HEAD
<<<<<<< HEAD
       SceneManager.LoadScene(1);
        
=======
        completeLevelUI.SetActive(true);
>>>>>>> parent of c06f2d5 (added sound :))
=======
        completeLevelUI.SetActive(true);
        FindObjectOfType<AudioManager>().Play("LevelComplete");
>>>>>>> parent of 582d66e (Added a new scene to act as a menu when you finish the level. You now get the option to either play again or to quit game if you win.)
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
