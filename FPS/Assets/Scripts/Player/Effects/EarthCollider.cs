using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthCollider : MonoBehaviour
{
    public PlayerHealth playerhealth;
    public HealthBar healthbar;
    public Target target;
    public int firedamage;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerhealth.DisplayHitBlood();
            firedamage = 1;
            playerhealth.currentHealth = playerhealth.currentHealth - firedamage;
            healthbar.SetHeath(playerhealth.currentHealth);
            firedamage += 1;
        }
        if (other.tag == "Enemy")
        {
            firedamage = 1;
            target.health = target.health - firedamage;
            firedamage += 1;
        }
    }
}
