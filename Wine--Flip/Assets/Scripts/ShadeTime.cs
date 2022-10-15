using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadeTime : MonoBehaviour
{
    Player player;
    public GameObject playerOB;
    private Animator anim;

    void Start()
    {
        player = playerOB.GetComponent<Player>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetMouseButton(0) && player.isGrounded == true)
        {
            anim.SetBool("ShadeT", true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("ShadeT", false);
        }
        else
        {
            anim.SetBool("ShadeT", false);
        }
    }

}
