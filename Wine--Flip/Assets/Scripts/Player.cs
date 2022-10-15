using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public LineRenderer _lineRenderer;
    public GameObject position2;
    public bool isGrounded;
    public Transform GroundCheck;
    public float CheckRadious;
    public LayerMask WhatIsGround;
    public float offset;
    private Animator anim;
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        _lineRenderer = GetComponent<LineRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

     void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, CheckRadious, WhatIsGround);
    }
    void Update()
    {

        if(Input.GetMouseButton(0) && isGrounded == true)
        {
            _lineRenderer.enabled = true;
            _lineRenderer.SetPosition(0, position2.transform.position);
        _lineRenderer.SetPosition(1, transform.position);
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
            anim.SetBool("Squash", true);
        }
        else if(Input.GetMouseButtonUp(0) && isGrounded == true)
        {
            anim.SetBool("Squash", false);
            _lineRenderer.enabled = false;
            rb.velocity = transform.up * speed;
        }
        else
        {
            anim.SetBool("Squash", false);
            _lineRenderer.enabled = false;
        }
     
     
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            rb.velocity = Vector2.up * speed;
        }
    }
}
