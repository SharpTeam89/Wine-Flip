using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCScript : MonoBehaviour
{
    public Vector3 StartPosition;
    public float minimumDistance;
    public float speed;
    public Transform GoalPosition;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Vector2.Distance(transform.position, GoalPosition.position) < minimumDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, GoalPosition.position, speed * Time.deltaTime);
            
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, StartPosition, speed * Time.deltaTime);
           
        }
    }
}
