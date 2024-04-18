using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField ]private float currentEnemyHealth;
    [SerializeField] private float maxEnemyHealth;

    [SerializeField] private int moneyGain;

    [SerializeField] private AudioSource deathSound;

    public LoadsaMoney loadmoni;
    void Start()
    {
        maxEnemyHealth = 1;
        currentEnemyHealth = maxEnemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)) 
        {
            LoseHealth();
        }

        if(currentEnemyHealth <= 0)
        {
            Dead();
        }
    }

    public void LoseHealth()
    {
        currentEnemyHealth -= 1;
    }

    void Dead()
    {
        loadmoni.AddSoftCurrencyEnemyDeath(moneyGain);
        PlayerPrefs.SetInt("amount", loadmoni.hellaSoft); //lagrer mengden i hellaCash som int i PlayerPref
        deathSound.Play();
        Handheld.Vibrate();
        Destroy(gameObject);
    }
}
