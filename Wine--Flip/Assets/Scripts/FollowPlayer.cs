using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform GoalPosition;
    public float speed;
    public float speed2;
    public float minimumDistance;
    public float maximumDistance;

    void Start()
    {

    }


    void Update()
    {

        if (Vector2.Distance(transform.position, GoalPosition.position) < minimumDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, GoalPosition.position, speed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, GoalPosition.position) > maximumDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, GoalPosition.position, speed2 * Time.deltaTime);
        }

    }
}
