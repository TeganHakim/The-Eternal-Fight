using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool IsShatter;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            IsShatter = true;
            Invoke("SetFalse", 10);
        }
        else
        {
            IsShatter = false;
        }
    }
    void SetFalse()
    {
        IsShatter = false;
    }
}
