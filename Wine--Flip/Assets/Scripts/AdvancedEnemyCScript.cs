using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedEnemyCScript : MonoBehaviour
{
    public Vector3 StartPosition;
    public float minimumDistance;
    public float maximumDistance;
    public float speed;
    private Transform GoalPosition;
    private GameObject tPlayer;
    public GameObject DeathParticle;
    public GameObject Výbuch;
    private Transform OtherEnemy;
    private GameObject tEnemy;
    private Transform NearbyGround;
    private GameObject tGround;
    public float EnemyDistance;
    public float EnemySpeed;
    public bool Died;

    void Start()
    {
        Died = false;
        tPlayer = GameObject.FindWithTag("Player");
        GoalPosition = tPlayer.transform;
        tEnemy = GameObject.FindWithTag("Enemy");
        OtherEnemy = tEnemy.transform;
        tGround = GameObject.FindWithTag("Ground");
        NearbyGround = tGround.transform;
    }


    void Update()
    {
        if (Vector2.Distance(transform.position, NearbyGround.position) < EnemyDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, NearbyGround.position, EnemySpeed * Time.deltaTime);

        }

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
