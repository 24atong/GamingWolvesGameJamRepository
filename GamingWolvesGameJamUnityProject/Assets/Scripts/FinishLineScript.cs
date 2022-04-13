using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Player").SendMessage("Finish");
<<<<<<< HEAD
<<<<<<< HEAD
        FindObjectOfType<AudioManager>().Play("LevelComplete");
=======
>>>>>>> parent of d677fa8 (finishing level sound should work now)
        SceneManager.LoadScene(1);
=======
>>>>>>> parent of 582d66e (Added a new scene to act as a menu when you finish the level. You now get the option to either play again or to quit game if you win.)
    }
}
