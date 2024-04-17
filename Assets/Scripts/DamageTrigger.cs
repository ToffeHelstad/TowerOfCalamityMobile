using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{

    public EnemyHealth enemyHealth;
    public PlayerHealth playerHealth;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            enemyHealth.LoseHealth();
        }

        if (collision.tag == "Player")
        {
            playerHealth.LoseHealth();
        }
    }
}
