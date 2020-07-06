using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonWeaponSelect : MonoBehaviour
{
    public Button SelectButton;
    public WeaponSwitching weaponslot;
    public int gun;
    public GameObject StG44;
    public GameObject Ak47;
    public GameObject Flame;

    // Update is called once per frame
    private void Update()
    {
        SelectButton.onClick.AddListener(() => OnClick());
    }
    void OnClick()
    {

        if (gun == 0)
        {
            StG44.SetActive(true);
            Ak47.SetActive(false);
            Flame.SetActive(false);
            weaponslot.SelectedWeapon = 0;
        }
        if (gun == 1)
        {
            StG44.SetActive(false);
            Ak47.SetActive(true);
            Flame.SetActive(false);
            weaponslot.SelectedWeapon = 1;
        }
        if (gun == 2)
        {
            StG44.SetActive(false);
            Ak47.SetActive(false);
            Flame.SetActive(true);
            weaponslot.SelectedWeapon = 1;
        }
        weaponslot.SelectedWeapon = gun;
    }
}
