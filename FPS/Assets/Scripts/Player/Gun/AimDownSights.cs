using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimDownSights : MonoBehaviour
{
    public Vector3 aimDownSights;
    public Vector3 hipFire;
    public GameObject crosshair;
    public GameObject text;

    //0, 0.1699999, 4.17

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(1))
        {
            text.SetActive(false);
            transform.localPosition = Vector3.Slerp(transform.localPosition, aimDownSights, 4 * Time.deltaTime);
            crosshair.SetActive(false);

        }
        
        if (Input.GetMouseButtonUp(1))
        {
            transform.localPosition = hipFire;
            crosshair.SetActive(true);
            text.SetActive(true);
        }

    }
}
