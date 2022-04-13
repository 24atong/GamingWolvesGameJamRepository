using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Player").SendMessage("Finish");
        FindObjectOfType<AudioManager>().Play("LevelComplete");
        SceneManager.LoadScene(1);
    }
}
