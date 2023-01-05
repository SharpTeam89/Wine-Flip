using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject FP;
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
            Instantiate(FP, transform.position, transform.rotation);
        }
    }
}
