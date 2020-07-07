using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseScreen;
    public Intro intro;
    
    public GameObject inventory;
    public GunScript gun;
    public CharacterController playerM;
    public PlayerMovement playerM2;
    public MouseLook playerL;
    public AimDownSights aim;
    public AimDownSights aim2;
    public AimDownSights aim3;
    public Ammo ammo;
    public Ammo ammo2;
    public Ammo ammo3;
    public GameObject HealthBar;
    public GameObject manaBar;
    public GameObject Enemy;
    public GameObject MiniMap;
    public GameObject Crosshair;
    public GameObject ammoText;
    public WeaponSwitching weaponswitching;

    private bool CursorLock;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;

            
            inventory.SetActive(false);
            CursorLock = true;
            gun.enabled = false;
            playerM.enabled = false;
            playerM2.enabled = false;
            playerL.enabled = false;
            aim.enabled = false;
            aim2.enabled = false;
            aim3.enabled = false;
            ammo.reloadammo = false;
            ammo2.reloadammo = false;
            HealthBar.SetActive(false);
            manaBar.SetActive(false);
            Enemy.SetActive(false);            
            MiniMap.SetActive(false);
            Crosshair.SetActive(false);
            ammoText.SetActive(false);
            weaponswitching.enabled = false;
        }

        if (CursorLock == false && intro.introscreen == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        if (CursorLock == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }



    public void ResumeClick()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;


        inventory.SetActive(false);
        CursorLock = false;
        gun.enabled = true;
        playerM.enabled = true;
        playerM2.enabled = true;
        playerL.enabled = true;
        aim.enabled = true;
        aim2.enabled = true;
        aim3.enabled = true;
        ammo.reloadammo = true;
        ammo2.reloadammo = true;
        HealthBar.SetActive(true);
        manaBar.SetActive(true);
        Enemy.SetActive(true);
        MiniMap.SetActive(true);
        Crosshair.SetActive(true);
        ammoText.SetActive(true);
        weaponswitching.enabled = true;

        if (CursorLock == false && intro.introscreen == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        if (CursorLock == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }


    public void QuitClick()
    {
        Application.Quit();
    }
}
