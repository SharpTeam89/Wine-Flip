using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCScript : MonoBehaviour
{
    public Vector3 StartPosition;
    public float minimumDistance;
    public float maximumDistance;
    public float speed;
    public Transform GoalPosition;
    public GameObject DeathParticle;
    public GameObject Výbuch;
    public Transform OtherEnemy;
    public float EnemyDistance;
    public float EnemySpeed;
    public bool Died;

    void Start()
    {
        Died = false;
    }

    
    void Update()
    {
        if (Vector2.Distance(transform.position, OtherEnemy.position) < EnemyDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, OtherEnemy.position, EnemySpeed * Time.deltaTime);

        }

        if (Vector2.Distance(transform.position, GoalPosition.position) < minimumDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, GoalPosition.position, speed * Time.deltaTime);
            
        }
        else if (Vector2.Distance(transform.position, GoalPosition.position) < maximumDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, GoalPosition.position, -speed * Time.deltaTime);

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, StartPosition, speed * Time.deltaTime);
           
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Died = true;
            Destroy(gameObject);
            Instantiate(DeathParticle, transform.position, Quaternion.identity);
            Instantiate(Výbuch, transform.position, Quaternion.identity);
        }
    }
}
