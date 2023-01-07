using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToTarget : MonoBehaviour
{
    private Transform target;
    private GameObject tPlayer;

    void Start()
    {
        tPlayer = GameObject.FindWithTag("ST");
        target = tPlayer.transform;
    }

    
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        transform.up = target.transform.position - transform.position;
    }
}
