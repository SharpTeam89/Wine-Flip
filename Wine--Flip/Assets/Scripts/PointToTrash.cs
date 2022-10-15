using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToTrash : MonoBehaviour
{
    public Transform target;


    void Start()
    {
        
    }

  
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        transform.up = target.transform.position - transform.position;
    }
}
