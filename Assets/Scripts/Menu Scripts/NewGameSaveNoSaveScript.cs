using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameSaveNoSaveScript : MonoBehaviour
{
    public MenuSaveDummyScript SaveScript;
    public GameObject NewSaveMenu;
    public GameObject SavePresentPopup;


    public void NewSaveLogic()
    {
        if (SaveScript.GameSaved)
        {
            SavePresentPopup.SetActive(true);
        }
        else
        {
            NewSaveMenu.SetActive(true);
        }
    }
}
