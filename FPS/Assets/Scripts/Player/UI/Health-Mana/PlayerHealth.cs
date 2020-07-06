using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;


    public HealthBar healthbar;

    public int maxMana = 100;
    public int currentMana;
    bool run = true;
    public SlowTime timeslow;
    private int damagenumber = 5;
    

    public ManaBar manabar;
    public GameObject diescreen;
    public GameObject Slowtime;
    public PlayerMovement player;

    public GameObject hitblood;

   
    


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);

        currentMana = maxMana;
        manabar.SetMaxMana(maxMana);

        damagenumber = 5;
        hitblood.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
       
       if (Input.GetKey(KeyCode.LeftShift))
       {
           DecreaseMana(1);
       }

       if(currentMana < maxMana && Input.GetKeyUp(KeyCode.LeftShift))
       {
            StartCoroutine(RegenMana());

           if (currentMana == maxMana)
               currentMana = maxMana;

       }
       if(currentMana <= 30)
        {
            Slowtime.SetActive(false);
            Time.timeScale = 1f;
            player.speed = 6;
        }
       else
        {
            Slowtime.SetActive(true);
        }
       if (currentMana <= 0)
           currentMana = 0;
       if (currentMana < 30)
           timeslow.enabled = false;
       if (currentMana > 30)
           timeslow.enabled = true;

       if(currentHealth <= 0)
        {
            diescreen.SetActive(true);
            if (Input.GetKey(KeyCode.R))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
       else
        {
            diescreen.SetActive(false);
        }

       
        

    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("bullet"))
        {
            
            TakeDamage(damagenumber);
            damagenumber += 2;


        }
    }

    void TakeDamage(int damage)
    {
        
        currentHealth -= damage;
        if (currentMana <= 0)
            currentMana = 0;
           

        healthbar.SetHeath(currentHealth);
        StartCoroutine(DisplayHitBlood());
    }
    public IEnumerator DisplayHitBlood()
    {
        hitblood.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        hitblood.SetActive(false);
    }
    

    void DecreaseMana(int decrease)
    {
        currentMana -= decrease;

        manabar.SetMana(currentMana);
    }
    
    private IEnumerator RegenMana()
    {
        yield return new WaitForSeconds(1.2f);

        while (currentMana < maxMana)
        {
            currentMana += maxMana / 200;
            manabar.SetMana(currentMana);
            yield return new WaitForSeconds(0.1f);
        }
    }








   

   
}
