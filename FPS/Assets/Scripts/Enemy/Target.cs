using System.Collections;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public Text killLog;
    public WeaponSwitching weaponslot;
    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
            killLog.CrossFadeAlpha(255f, 1, false);
            if (weaponslot.SelectedWeapon == 0)
            {
                killLog.text = gameObject.name + " eliminated with StG-44";
                killLog.CrossFadeAlpha(0f, 15, false);
            }
            if (weaponslot.SelectedWeapon == 1)
            {
                killLog.text = gameObject.name + " eliminated with Ak-47";
                killLog.CrossFadeAlpha(0f, 15, false);
            }
            if (weaponslot.SelectedWeapon == 2)
            {
                killLog.text = gameObject.name + " incinerated with FlameThrower";
                killLog.CrossFadeAlpha(0f, 15, false);
            }


        }
    }



    void Die ()
    {
        Destroy(gameObject);
    }


}
