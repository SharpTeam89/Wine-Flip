using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform GoalPosition;
    public float speed;

    void Start()
    {

    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, GoalPosition.position, speed * Time.deltaTime);
    }
}
