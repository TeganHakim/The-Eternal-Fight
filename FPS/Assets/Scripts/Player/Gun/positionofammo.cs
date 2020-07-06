using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionofammo : MonoBehaviour
{

    public WeaponSwitching weapon;
    public Vector3 pos;
    public Vector3 pos2;
    public Vector3 pos3;


    // Update is called once per frame
    void Update()
    {
        if (weapon.SelectedWeapon == 0)
        {
            transform.localPosition = pos;
        }
        if (weapon.SelectedWeapon == 1)
        {
            transform.localPosition = pos2;
        }
        if (weapon.SelectedWeapon == 2)
        {
            transform.localPosition = pos3;
        }
    }
}
