using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{

    public float TimeSpeedSlow = 0.25f;
    public float TimeSpeedNormal = 1.0f;
    public PlayerMovement player;
    public float speedMultiplyer = 1.05f;

    [SerializeField]
    KeyCode keyv;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKey(keyv))
        {
            Time.timeScale = TimeSpeedSlow;
            player.speed = speedMultiplyer;
        }
        if (Input.GetKeyUp(keyv))
        {
            Time.timeScale = TimeSpeedNormal;
            player.speed = 6;
        }
    }

    

    
}
