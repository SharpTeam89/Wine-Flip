using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blurp : MonoBehaviour
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
            anim.SetBool("BlurpOP", true);
            anim.SetBool("Enable", false);

        }
        else 
        {
            anim.SetBool("Enable", true);
            anim.SetBool("BlurpOP", false);

        }
    }
}
