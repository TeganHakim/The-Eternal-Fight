﻿using System.Collections;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class TargetBullet : MonoBehaviour
{
    public float health = 50f;
    
    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
            
        }
    }



    void Die ()
    {
        Destroy(gameObject);
    }


}
