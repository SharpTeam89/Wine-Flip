using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScreen : MonoBehaviour
{
    public GameObject PlayerOB;
    public GameObject PlayerOBT;
    public GameObject ParticleOB;
    public int Scene;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           
            SceneManager.LoadScene(Scene);
        }
    }

    
        
}
