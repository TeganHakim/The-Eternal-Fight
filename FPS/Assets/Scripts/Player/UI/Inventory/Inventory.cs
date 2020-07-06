using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    
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

    private bool CursorLock;
    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            
            
            inventory.SetActive(!inventory.activeSelf);
            //Cursor.lockState = CursorLockMode.None;
            CursorLock = (!CursorLock);
            gun.enabled = !gun.enabled;
            playerM.enabled = !playerM.enabled;
            playerM2.enabled = !playerM2.enabled;
            playerL.enabled = !playerL.enabled;
            aim.enabled = !aim.enabled;
            aim2.enabled = !aim2.enabled;
            aim3.enabled = !aim3.enabled;
            ammo.reloadammo = !ammo.reloadammo;
            ammo2.reloadammo = !ammo2.reloadammo;
            ammo3.reloadammo = !ammo3.reloadammo;


        }
        if(CursorLock == false && intro.introscreen == false)
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
}
