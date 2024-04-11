using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameSaveNoSaveScript : MonoBehaviour
{
    public bool SaveStarted;
    public GameObject NewSaveMenu;
    public GameObject SavePresentPopup;

    public void NewSaveLogic()
    {
        if (SaveStarted)
        {
            SavePresentPopup.SetActive(true);
        }
        else
        {
            NewSaveMenu.SetActive(true);
        }
    }
}
