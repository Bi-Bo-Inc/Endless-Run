using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;

public class FishController : MonoBehaviour
{
    private float swimForce = 0;
  
    private Rigidbody2D rb;

    private float acceleration = 0.3f; // ускорение
    private float maxSwimForce = 6.5f; // максимальная скорость
    private float fishRotation = 0;
    public float maxFishRotation = 17f;
    public float fishAcceleration = 1f;


    private float secondsToStart = 1.5f;
    private float startSpeed = 1.9f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate()
    {

        if(secondsToStart > 0)
        {
            secondsToStart -= Time.deltaTime;
            rb.velocity = new Vector2(startSpeed, 0);
            



        }
        else
        {
            
            Game();
        }
       

    }

    
    private void Game()
    {
        Movement(swimForce);
        FishRotation(fishRotation);
        //  ниже изменение ускорения
        if (Input.GetKey(KeyCode.Space))
        {
            if (swimForce < maxSwimForce)
                swimForce += acceleration;



            if (fishRotation < maxFishRotation)
            {
                fishRotation += fishAcceleration;

                // transform.rotation = Quaternion.Euler(0, 0, fishRotation);
            }

        }
        else
        {
            if (swimForce > -maxSwimForce)
                swimForce -= acceleration;



            if (fishRotation > -maxFishRotation)
            {
                fishRotation -= fishAcceleration;

            }

        }
    }
    
    private void FishRotation (float fishRotation)
    {
        transform.rotation = Quaternion.Euler(0, 0, fishRotation);
    }
   
    private void Movement(float swimForce)
    {        
        rb.velocity = new Vector2(0, swimForce);
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);           
        }
    }
}
