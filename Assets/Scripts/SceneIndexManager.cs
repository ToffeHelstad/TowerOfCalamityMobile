using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneIndexManager : MonoBehaviour
{
    public string GameSceneName;
    public string MainMenuName;

    public void ChangeToGameScene()
    {
        SceneManager.LoadScene(GameSceneName);
    }

    public void ChangeToMainMenu()
    {
        SceneManager.LoadScene(MainMenuName);
    }
}
