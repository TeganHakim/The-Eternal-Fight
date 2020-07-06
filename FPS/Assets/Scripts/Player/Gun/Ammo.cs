using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{
    public MeshRenderer cube;
    public int ammo;
    public Vector3 reload;
    //public Vector3 hipFire;
    public Text text;
    public GameObject textGame;
    public AimDownSights aim;
    public bool reloadammo = true;
    public WeaponSwitching weaponslot;


    [SerializeField]
    KeyCode keyr;
    


    // Update is called once per frame
    void Update()
    {
        if (weaponslot.SelectedWeapon == 0)
            text.text = ammo + " / 100";
        if (weaponslot.SelectedWeapon == 1)
            text.text = ammo + " / 100";
        if (weaponslot.SelectedWeapon == 2)
            text.text = ammo + " / 50";


        Color color = cube.material.color;
        if (weaponslot.SelectedWeapon == 0)
        {
            if (ammo == 100)
            {
                color.r = 0;
                color.g = 255;
                color.b = 0;
                cube.material.color = color;
                cube.material.SetColor("_EmissionColor", color);
            }
            if (ammo == 60)
            {
                color.r = 255;
                color.g = 255;
                color.b = 0;
                cube.material.color = color;
                cube.material.SetColor("_EmissionColor", color);
            }
            if (ammo == 20)
            {
                color.r = 255;
                color.g = 0;
                color.b = 0;
                cube.material.color = color;
                cube.material.SetColor("_EmissionColor", color);
            }
            if (ammo == 0)
            {
                if (reloadammo == true)
                {
                    GameObject.Find("Gun").GetComponent<GunScript>().enabled = false;
                    textGame.SetActive(false);
                    transform.localPosition = Vector3.Slerp(transform.localPosition, reload, 3 * Time.deltaTime);
                    Invoke("Reload", 2);
                }

            }
        }
        if (weaponslot.SelectedWeapon == 1)
        {
            if (ammo == 100)
            {
                color.r = 0;
                color.g = 255;
                color.b = 0;
                cube.material.color = color;
                cube.material.SetColor("_EmissionColor", color);
            }
            if (ammo == 60)
            {
                color.r = 255;
                color.g = 255;
                color.b = 0;
                cube.material.color = color;
                cube.material.SetColor("_EmissionColor", color);
            }
            if (ammo == 20)
            {
                color.r = 255;
                color.g = 0;
                color.b = 0;
                cube.material.color = color;
                cube.material.SetColor("_EmissionColor", color);
            }
            if (ammo == 0)
            {
                if (reloadammo == true)
                {
                    GameObject.Find("Gun").GetComponent<GunScript>().enabled = false;
                    textGame.SetActive(false);
                    transform.localPosition = Vector3.Slerp(transform.localPosition, reload, 3 * Time.deltaTime);
                    Invoke("Reload", 2);
                }

            }
        }
        if (weaponslot.SelectedWeapon == 2)
        {
            if (ammo == 50)
            {
                color.r = 0;
                color.g = 255;
                color.b = 0;
                cube.material.color = color;
                cube.material.SetColor("_EmissionColor", color);
            }
            if (ammo == 30)
            {
                color.r = 255;
                color.g = 255;
                color.b = 0;
                cube.material.color = color;
                cube.material.SetColor("_EmissionColor", color);
            }
            if (ammo == 10)
            {
                color.r = 255;
                color.g = 0;
                color.b = 0;
                cube.material.color = color;
                cube.material.SetColor("_EmissionColor", color);
            }
            if (ammo == 0)
            {
                if (reloadammo == true)
                {
                    GameObject.Find("Gun").GetComponent<GunScript>().enabled = false;
                    textGame.SetActive(false);
                    transform.localPosition = Vector3.Slerp(transform.localPosition, reload, 3 * Time.deltaTime);
                    Invoke("Reload", 2);
                }

            }
        }
        
        if (weaponslot.SelectedWeapon == 0)
        {
            if (Input.GetKey(keyr))
            {
                if (reloadammo == true)
                {
                    GameObject.Find("Gun").GetComponent<GunScript>().enabled = false;
                    textGame.SetActive(false);
                    transform.localPosition = Vector3.Slerp(transform.localPosition, reload, 3 * Time.deltaTime);
                    Invoke("Reload", 2);
                }
            }
        }
        if (weaponslot.SelectedWeapon == 1)
        {
            if (Input.GetKey(keyr))
            {
                if (reloadammo == true)
                {
                    GameObject.Find("Gun").GetComponent<GunScript>().enabled = false;
                    textGame.SetActive(false);
                    transform.localPosition = Vector3.Slerp(transform.localPosition, reload, 3 * Time.deltaTime);
                    Invoke("Reload", 2);
                }
            }
        }
        if (weaponslot.SelectedWeapon == 2)
        {
            if (Input.GetKey(keyr))
            {
                if (reloadammo == true)
                {
                    GameObject.Find("Gun").GetComponent<GunScript>().enabled = false;
                    textGame.SetActive(false);
                    transform.localPosition = Vector3.Slerp(transform.localPosition, reload, 3 * Time.deltaTime);
                    Invoke("Reload", 2);
                }
            }
        }



    }

    void Reload()
    {
        if (weaponslot.SelectedWeapon == 0)        
            ammo = 100;
        if (weaponslot.SelectedWeapon == 1)
            ammo = 100;
        if (weaponslot.SelectedWeapon == 2)
            ammo = 50;
        transform.localPosition = Vector3.Slerp(transform.localPosition, aim.hipFire, 3);
        GameObject.Find("Gun").GetComponent<GunScript>().enabled = true;
        textGame.SetActive(true);
        
        
    }
    



}
