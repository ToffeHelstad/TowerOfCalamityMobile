using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float currentPlayerHealth;
    [SerializeField] private float maxPlayerHealth;

    [SerializeField] private AudioSource deathSound;

    public GameObject gameOverScreen;
    void Start()
    {
        maxPlayerHealth = 3;
        currentPlayerHealth = maxPlayerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            LoseHealth();
        }

        if (currentPlayerHealth <= 0)
        {
            Dead();
        }
    }

    public void LoseHealth()
    {
        currentPlayerHealth -= 1;
    }

    void Dead()
    {
        deathSound.Play();
        Handheld.Vibrate();
        gameOverScreen.SetActive(true);
        Destroy(gameObject);
    }
}
