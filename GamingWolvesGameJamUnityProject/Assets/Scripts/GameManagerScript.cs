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
        completeLevelUI.SetActive(true);
        FindObjectOfType<AudioManager>().Play("LevelComplete");
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
 
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
