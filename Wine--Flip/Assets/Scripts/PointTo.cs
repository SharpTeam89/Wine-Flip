using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTo : MonoBehaviour
{
    public float speed;

    void Start()
    {

    }


    void Update()
    {


        
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position = Vector2.MoveTowards(transform.position, pos, speed * Time.deltaTime);
        
    }
}
