using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireP : MonoBehaviour
{
    public GameObject FP;
    private float NST;
    public float NST2;
    private Transform GoalPosition;
    private GameObject tPlayer;
    public float minimumDistance;

    void Start()
    {
        tPlayer = GameObject.FindWithTag("ST");
        GoalPosition = tPlayer.transform;
    }

    
    void Update()
    {
        if (Vector2.Distance(transform.position, GoalPosition.position) < minimumDistance)
        {
            if (Time.time > NST)
            {
                NST = Time.time + NST2;
                Instantiate(FP, transform.position, transform.rotation);
            }
        }
    }
}
