using UnityEngine;

public class FishController : MonoBehaviour
{
    private float swimForce = 0;

    private Rigidbody2D rb;
   
    public float acceleration = 0.3f; // ускорение
    public float maxSwimForce = 6.5f; // максимальная скорость

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate()
    {

        Movement(swimForce);

        //  ниже изменение ускорения
        if (Input.GetKey(KeyCode.Space))
        {
            
           
            if(swimForce < maxSwimForce) 
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