using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoUp : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private float NST;
    public float NST2;
    public float speedPlus;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        rb.velocity = Vector2.up * speed;
        Timeron();
    }

    public void Timeron()
    {
        if(Time.time > NST)
        {
            NST = Time.time + NST2;
            speed += speedPlus;
        }
    }
}
