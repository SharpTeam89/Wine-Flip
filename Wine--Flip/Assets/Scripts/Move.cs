using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Speed;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rb.velocity = Vector2.down * Speed;

    }




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Default")
        {

            Destroy(gameObject);

        }
    }
}
