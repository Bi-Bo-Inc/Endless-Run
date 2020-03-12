using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFishController : MonoBehaviour
{
    private float swimForce = 0;

    private Rigidbody2D rb;

    private float acceleration = 0.3f; // ускорение
    private float maxSwimForce = 6.5f; // максимальная скорость

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    

    private void FixedUpdate()
    {

        Movement(swimForce);

        //  ниже изменение ускорения
        if (Input.touchCount > 0 && ((Input.GetTouch(0).phase == TouchPhase.Moved) || (Input.GetTouch(0).phase == TouchPhase.Stationary)|| (Input.GetTouch(0).phase == TouchPhase.Began)))
        {


            if (swimForce < maxSwimForce) 
                swimForce += acceleration;  
        }
        else 
        {
            
            
            if (swimForce > -maxSwimForce)
                swimForce -= acceleration;
            
        }
    }
    private void Movement(float swimForce)
    {
        
        rb.velocity = new Vector2(0, swimForce);
        
    }

    
    
}
