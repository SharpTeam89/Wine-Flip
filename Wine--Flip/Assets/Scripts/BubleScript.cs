using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubleScript : MonoBehaviour
{
    public float Scale;
    public float SScale;
    public float Speed;
    public GameObject P;
    private float NST;
    public float NST2;
    public float PlusOne;


    void Start()
    {
        
        transform.localScale = new Vector3(SScale, SScale, 0);
    }

    
    void Update()
    {
        transform.position = transform.position + new Vector3(0, Speed, 0);
        transform.localScale = transform.localScale + new Vector3(Scale, Scale, 0);
        if (Time.time > NST)
        {
            NST = Time.time + NST2;
            PlusOne += 1;
        }

        if ( PlusOne == 22)
        {
           
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Default")
        {
            Instantiate(P, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }

    }

    void DestroyG()
    {
        Instantiate(P, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
