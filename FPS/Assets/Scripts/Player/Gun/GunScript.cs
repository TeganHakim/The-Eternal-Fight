
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 75f;
    public float firerate = 15f;
    public float firerate2 = 5f;
    public float damage2 = 20f;
    public float range2 = 150f;
    public float firerate3 = 15f;
    public float damage3 = 40f;
    public float range3 = 40f;


    public GameObject gun;
    public GameObject gun2;
    public GameObject gun3;
    public ParticleSystem muzzleflash;
    public ParticleSystem muzzleflash2;
    public ParticleSystem muzzleflash3;
    public WeaponSwitching weaponslot;
    public GameObject impacteffect;
    public Ammo ammo;
    public Ammo ammo2;
    public Ammo ammo3;

    public float impactForce = 30f;
    public float impactForce2 = 30f;
    public float impactForce3 = 15f;
    private float nexTimetoFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nexTimetoFire)
        {
            
            
            if (weaponslot.SelectedWeapon == 0)
            {
                nexTimetoFire = Time.time + 1f / firerate;
                ammo.ammo = ammo.ammo - 1;
                Shoot();
            }

            if (weaponslot.SelectedWeapon == 1)
            {
                nexTimetoFire = Time.time + 1f / firerate2;
                ammo2.ammo = ammo2.ammo - 1;
                Shoot2();
            }
            if (weaponslot.SelectedWeapon == 2)
            {
                nexTimetoFire = Time.time + 1f / firerate2;
                ammo3.ammo = ammo3.ammo - 2;
                Shoot3();
            }
        }



    }

    void Shoot()
    {

        muzzleflash.Play();

        RaycastHit hit;
        if (Physics.Raycast(gun.transform.position, gun.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

        }   GameObject impactG = Instantiate(impacteffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactG, 2f);
    }       
    void Shoot2()
    {
        muzzleflash2.Play();

        RaycastHit hit2;
        if (Physics.Raycast(gun2.transform.position, gun2.transform.forward, out hit2, range2))
        {
            Debug.Log(hit2.transform.name);

            Target target = hit2.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage2);
            }

            if (hit2.rigidbody != null)
            {
                hit2.rigidbody.AddForce(-hit2.normal * impactForce2);
            }


        }   GameObject impactGo = Instantiate(impacteffect, hit2.point, Quaternion.LookRotation(hit2.normal));
            Destroy(impactGo, 2f);

    }
    void Shoot3()
    {
        muzzleflash3.Play();

        RaycastHit hit3;
        if (Physics.Raycast(gun3.transform.position, gun3.transform.forward, out hit3, range3))
        {
            Debug.Log(hit3.transform.name);

            Target target = hit3.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage3);
            }

            if (hit3.rigidbody != null)
            {
                hit3.rigidbody.AddForce(-hit3.normal * impactForce3);
            }

            
        }
        

    }
}

   

    



