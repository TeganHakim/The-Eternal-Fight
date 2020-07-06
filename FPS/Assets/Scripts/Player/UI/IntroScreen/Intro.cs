using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public GameObject IntroScreen;
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
    public GameObject Spawn;
    public WeaponSwitching weaponswitching;

    public bool introscreen;

    public GameObject ControlScreen;
    public GameObject ControlScreen2;
    public Scrollbar scrollbar1;
    public Scrollbar scrollbar2;

    public GameObject Aboutpage;




    // Start is called before the first frame update
    void Start()
    {
        introscreen = true;
        IntroScreen.SetActive(true);
        inventory.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
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
        Spawn.SetActive(false);
        weaponswitching.enabled = false;

    }

    public void ControlButton()
    {
        ControlScreen.SetActive(true);
        ControlScreen2.SetActive(false);
    }

    public void StartButton()
    {
        introscreen = false;
        IntroScreen.SetActive(false);
        inventory.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
        Spawn.SetActive(true);
        Invoke("SpawnEnd", 2);
        weaponswitching.enabled = true;

    }
    
    public void AboutButton()
    {
        Aboutpage.SetActive(true);
    }




    void SpawnEnd()
    {
        Spawn.SetActive(false);
    }
    public void BackButton()
    {
        IntroScreen.SetActive(true);
        ControlScreen.SetActive(false);
        ControlScreen2.SetActive(false);
        Aboutpage.SetActive(false);
    }
    public void ControlScroll1()
    {
        if (scrollbar2.value == 0)
        {
            scrollbar1.value = 0;
            ControlScreen.SetActive(true);
            ControlScreen2.SetActive(false);
        }
        
    }
    public void ControlScroll2()
    {
        if (scrollbar1.value == 1)
        {
            scrollbar2.value = 1;
            ControlScreen2.SetActive(true);
            ControlScreen.SetActive(false);
        }
        
    }
    
}
    