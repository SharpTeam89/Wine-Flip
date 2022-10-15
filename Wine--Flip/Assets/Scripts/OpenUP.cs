using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUP : MonoBehaviour
{

    private Animator anim;
    public bool Yes;
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }


 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("Anim?", true);

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            anim.SetBool("Anim?", false);
        }
    }
}
