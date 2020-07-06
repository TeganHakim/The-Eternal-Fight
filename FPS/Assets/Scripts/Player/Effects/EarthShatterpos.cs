using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthShatterpos : MonoBehaviour
{
    public Transform player;
    public int xvar;
    public int zvar;
    public int yvar;
    

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3(player.position.x + xvar, player.position.y + yvar, player.position.z + zvar);
        transform.rotation = player.rotation.normalized;
    }
}
