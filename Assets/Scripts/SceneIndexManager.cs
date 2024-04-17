using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneIndexManager : MonoBehaviour
{
    public string GameSceneName;

    public void ChangeToGameScene()
    {
        SceneManager.LoadScene(GameSceneName);
    }
}
