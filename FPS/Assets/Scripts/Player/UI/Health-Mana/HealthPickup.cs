using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public PlayerHealth health;
    public HealthBar healthbar;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            health.currentHealth += 20;

            healthbar.SetHeath(health.currentHealth);
        }
    }
}
