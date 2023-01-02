using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour
{
    private float NST;
    public float NST2;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Time.time > NST)
        {
            NST = Time.time + NST2;
            
        }
    }
}
