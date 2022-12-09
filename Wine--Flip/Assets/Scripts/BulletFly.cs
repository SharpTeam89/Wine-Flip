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
        transform.Translate(transform.right * speed * Time.deltaTime);
    }

    void DestroyG()
    {
        Destroy(gameObject);
    }
}
