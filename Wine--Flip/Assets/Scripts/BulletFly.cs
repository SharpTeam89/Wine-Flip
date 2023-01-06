using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("DestroyG", 10f);
    }

 
    void Update()
    {
        rb.velocity = transform.up * speed;
    }

    void DestroyG()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && other.tag == "Enemy")
        {
            Destroy(gameObject);
        }

        if (other.tag == "Crate")
        {
            Destroy(gameObject);
        }
    }
}
