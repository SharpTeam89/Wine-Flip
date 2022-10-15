using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScriptBlow : MonoBehaviour
{

    private Animator anim;
    Player player;
    public GameObject playerOB;

    void Start()
    {
        anim = GetComponent<Animator>();
        player = playerOB.GetComponent<Player>();

    }


    void Update()
    {
        if (Input.GetMouseButton(0) && player.isGrounded == true)
        {

            anim.SetBool("Bloom", true);
        }
        else 
        {
            anim.SetBool("Bloom", false);
           

        }
    }
}

