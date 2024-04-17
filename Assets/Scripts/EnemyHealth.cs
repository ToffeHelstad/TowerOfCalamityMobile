using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField ]private float currentHealth;
    [SerializeField] private float maxHealth;

    [SerializeField] private int moneyGain;

    [SerializeField] private AudioSource deathSound;

    public LoadsaMoney loadmoni;
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)) 
        {
            LoseHealth();
        }

        if(currentHealth <= 0)
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
        loadmoni.AddSoftCurrencyEnemyDeath(moneyGain);
        PlayerPrefs.SetInt("amount", loadmoni.hellaSoft); //lagrer mengden i hellaCash som int i PlayerPref
        deathSound.Play();
        Destroy(gameObject);
    }
}
