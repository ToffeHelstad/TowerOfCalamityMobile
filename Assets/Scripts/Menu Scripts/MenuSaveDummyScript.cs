using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSaveDummyScript : MonoBehaviour
{
    public bool GameSaved;
    public GameObject continueButton;

    private void Update()
    {
        if (GameSaved)
        {
            continueButton.SetActive(true);
        }
        else
        {
            continueButton.SetActive(false);
        }
    }

    public void DummySaveGame()
    {
        if (GameSaved == false)
            GameSaved = true;
        else
            GameSaved = false;
    }

}
