using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private bool Touched;
    private Transform GoalPosition;
    public float speed;
    public float speed2;
    public float minimumDistance;
    public float maximumDistance;
    private GameObject tPlayer;
    public GameObject Particle;
    public GameObject Particle2;
    public float Touch;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        Touched = false;
        tPlayer = GameObject.FindWithTag("Player");
        GoalPosition = tPlayer.transform;
        Touch = 0; 
        anim.SetBool("Touched", false);
    }

    
    void Update()
    {
       

        if (Touched == true)
        {
            if (Vector2.Distance(transform.position, GoalPosition.position) < minimumDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, GoalPosition.position, speed * Time.deltaTime);
            }

            if (Vector2.Distance(transform.position, GoalPosition.position) > maximumDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, GoalPosition.position, speed2 * Time.deltaTime);
            }

            if (Touch == 1)
            {
                Instantiate(Particle, transform.position, Quaternion.identity);
                Instantiate(Particle2, transform.position, Quaternion.identity);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Touched = true;
            Touch += 1;
            anim.SetBool("Touched", true);
        }

        if (other.tag == "Cage")
        {
            Instantiate(Particle2, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
