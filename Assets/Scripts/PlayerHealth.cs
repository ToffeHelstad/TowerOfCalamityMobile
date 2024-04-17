using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float currentHealth;
    [SerializeField] private float maxHealth;

    [SerializeField] private AudioSource deathSound;
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            LoseHealth();
        }

        if (currentHealth <= 0)
        {
            Dead();
        }
    }

    public void LoseHealth()
    {
        currentHealth -= 1;
    }

    void Dead()
    {
        deathSound.Play();
        Handheld.Vibrate();
        Destroy(gameObject);
    }
}
