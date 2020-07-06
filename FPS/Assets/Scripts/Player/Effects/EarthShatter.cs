using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthShatter : MonoBehaviour
{
    public GameObject shatter;
    public GameObject shatterCollider;
    public ParticleSystem shatterEarth;
    public GameObject gun;
    public GameObject gun2;
    public GameObject gun3;
    public Transform earthpos;
    public Pickup pickup;

    // Update is called once per frame
    void Update()
    {
        if (pickup.IsShatter == true)
        {
            shatterCollider.SetActive(false);
            RaycastHit hitshatter;
            if (Physics.Raycast(gun.transform.position, gun.transform.forward, out hitshatter, 60f))
            {
                if (Input.GetKey(KeyCode.T))
                {
                    GameObject ShatterE = Instantiate(shatter, hitshatter.point, Quaternion.LookRotation(hitshatter.normal));
                    Destroy(ShatterE, 7f);
                    shatterEarth.Play();
                    shatterCollider.SetActive(true);
                    GameObject ShatterCollide = Instantiate(shatterCollider, earthpos.position, Quaternion.LookRotation(hitshatter.normal));
                    Destroy(ShatterCollide, 3f);

                }
            }
            RaycastHit hitshatter2;
            if (Physics.Raycast(gun2.transform.position, gun2.transform.forward, out hitshatter2, 60f))
            {
                if (Input.GetKey(KeyCode.T))
                {
                    GameObject ShatterE = Instantiate(shatter, hitshatter2.point, Quaternion.LookRotation(hitshatter2.normal));
                    Destroy(ShatterE, 7f);
                    shatterEarth.Play();
                    shatterCollider.SetActive(true);
                    GameObject ShatterCollide = Instantiate(shatterCollider, earthpos.position, Quaternion.LookRotation(hitshatter2.normal));
                    Destroy(ShatterCollide, 3f);

                }
            }
            RaycastHit hitshatter3;
            if (Physics.Raycast(gun3.transform.position, gun3.transform.forward, out hitshatter3, 60f))
            {
                if (Input.GetKey(KeyCode.T))
                {
                    GameObject ShatterE = Instantiate(shatter, hitshatter3.point, Quaternion.LookRotation(hitshatter3.normal));
                    Destroy(ShatterE, 7f);
                    shatterEarth.Play();
                    shatterCollider.SetActive(true);
                    GameObject ShatterCollide = Instantiate(shatterCollider, earthpos.position, Quaternion.LookRotation(hitshatter3.normal));
                    Destroy(ShatterCollide, 3f);

                }
            }
        }
        
    }
}
