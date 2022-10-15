using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitWindow : MonoBehaviour
{
    public GameObject GlassBroke;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Instantiate(GlassBroke, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
