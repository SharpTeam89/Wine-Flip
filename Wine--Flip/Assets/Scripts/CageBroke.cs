using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageBroke : MonoBehaviour
{
   
       
        public GameObject Lock;
    public GameObject Blow;
    public GameObject CageParticle;

    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Key")
        {
            Invoke("Destruction", 1);
        }
    }

    public void Destruction()
    {
        Instantiate(Blow, transform.position, Quaternion.identity);
        Instantiate(CageParticle, transform.position, Quaternion.identity);
        Instantiate(Lock, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
