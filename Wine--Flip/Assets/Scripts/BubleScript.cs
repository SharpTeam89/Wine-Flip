using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubleScript : MonoBehaviour
{
    public float Scale;
    public float Speed;
    

    void Start()
    {
        Invoke("DestroyG", 10);
        
    }

    
    void Update()
    {
        transform.position = transform.position + new Vector3(0, Speed, 0);
        transform.localScale = transform.localScale + new Vector3(Scale, Scale, 0);
       
        
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Default")
        {
            Destroy(gameObject);
        }

    }

    void DestroyG()
    {
        Destroy(gameObject);
    }
}
