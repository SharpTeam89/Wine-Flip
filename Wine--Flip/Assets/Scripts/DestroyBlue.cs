using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlue : MonoBehaviour
{
    public GameObject Blow;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Instantiate(Blow, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}
