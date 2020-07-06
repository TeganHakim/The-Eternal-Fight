using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{

    public int SelectedWeapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == SelectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {

        int previousSelectedWeapon = SelectedWeapon;
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (SelectedWeapon >= transform.childCount - 1)
                SelectedWeapon = 0;
            else
                SelectedWeapon++;
            
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (SelectedWeapon <= 0)
                SelectedWeapon = 0;
            if (SelectedWeapon >= 2)
                SelectedWeapon = 2;
            else
                SelectedWeapon++;
            
        }

        if (previousSelectedWeapon != SelectedWeapon)
        {
            SelectWeapon();
        }

    }   }
