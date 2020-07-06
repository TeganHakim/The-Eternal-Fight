using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectArea : MonoBehaviour
{
    private bool detected;
    private GameObject target;
    public Transform enemy;

    public GameObject bullet;
    public Transform shootpoint;

    public float shootSpeed = 100f;
    public float TimetoShoot = 1.3f;
    private float  originalTime;
    
    // Start is called before the first frame update
    void Start()
    {
        originalTime = TimetoShoot;
    }

    // Update is called once per frame
    void Update()
    {
        //if(detected)
        //{
        //    enemy.LookAt(target.transform);
        //}
    }

    private void FixedUpdate()
    {
        if(detected)
        {
            TimetoShoot -= Time.deltaTime;

            if (TimetoShoot < 0)
            {
                ShootPlayer();
                TimetoShoot = originalTime;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            detected = true;
    }


    private void ShootPlayer()
    {
        GameObject currentBullet = Instantiate(bullet, shootpoint.position, shootpoint.rotation);
        Destroy(currentBullet, 3f);
        Rigidbody rig = currentBullet.GetComponent<Rigidbody>();

        rig.AddForce(transform.forward * shootSpeed, ForceMode.VelocityChange);
        

    }
}



