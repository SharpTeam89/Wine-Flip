using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownMAnager : MonoBehaviour
{
    public float slowdownFactor;
    public float slowdownLenght;
    Player player;
    public GameObject playerOB;

    void Awake()
    {
        player = playerOB.GetComponent<Player>();
    }

   
    void Update()
    {
        if (Input.GetMouseButton(0) && player.isGrounded == true)
        {
            Time.timeScale = slowdownFactor;
            Time.fixedDeltaTime = Time.timeScale * .02f;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Time.timeScale = slowdownLenght;
        }
        else
        {
            Time.timeScale = slowdownLenght;
        }
        


    }
}
