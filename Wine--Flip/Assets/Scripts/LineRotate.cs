using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRotate : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            ButtonD();
        }
       
    }

    public void ButtonD()
    {
        gameObject.transform.Rotate(0f, 0f, 5f);
    }
}
