using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject screen;

    public PlayerMovement pmovement;
    public void Retry()
    {
        pmovement.remainingRetries -= 1;

        if(pmovement.remainingRetries > 0)
        {
            screen.SetActive(false);
            SceneManager.LoadScene(1);
            pmovement.remainingRetries -= 1;
        }
        else if(pmovement.remainingRetries == 0)
        {
            screen.SetActive(false);
            SceneManager.LoadScene(0);
        }
    }
}
