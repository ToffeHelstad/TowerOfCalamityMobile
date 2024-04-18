using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeUnlockScript : MonoBehaviour
{
    public GameObject LockedCharacter1;
    public GameObject UnlockedCharacter1;
    public GameObject LockedCharacter2;
    public GameObject UnlockedCharacter2;

    public bool Char1Unlocked;
    public bool Char2Unlocked;
    // Start is called before the first frame update
    void Start()
    {
        Char1Unlocked = false;
        Char2Unlocked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UnlockCharacter1()
    {
        Char1Unlocked = true;
        LockedCharacter1.SetActive(false);
        UnlockedCharacter1.SetActive(true);
    }

    public void UnlockCharacter2()
    {
        Char2Unlocked = true;
        LockedCharacter2.SetActive(false);
        UnlockedCharacter2.SetActive(true);
    }

    public string GameSceneName;

    public void ChangeToGameScene()
    {
        SceneManager.LoadScene(GameSceneName);
    }

    public void Char1Selected()
    {
        
    }
}
