using UnityEngine;


public class FishController : MonoBehaviour
{
    private Rigidbody2D rb;

    private float swimForce = 0; //начальная скорость
    private float acceleration = 0.3f; //ускорение
    private float maxSwimForce = 6.5f; //максимальная скорость

    private float fishRotation = 0; //начальное положение
    private float fishAcceleration = 1f; //поворот
    private float maxFishRotation = 25f; //максимальный поворот

    private float secondsToStart = 1.5f;    //время до старта
    private float startSpeed = 1.9f;    //скорость выплывания рыбы

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
            if (!FishDeath.IsDeath)
                Game();
        }
    }
    
    private void Game()
    {
        Movement(swimForce);
        FishRotation(fishRotation);

        //  ниже изменение ускорения
        
        if ((Input.touchCount > 0 && ((Input.GetTouch(0).phase == TouchPhase.Moved) || (Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Began)))|| Input.GetKey(KeyCode.Space))
        {
            if (swimForce < maxSwimForce)
                swimForce += acceleration;

            if (fishRotation < maxFishRotation)            
                fishRotation += fishAcceleration;
        }
        else
        {
            if (swimForce > -maxSwimForce)
                swimForce -= acceleration;

            if (fishRotation > -maxFishRotation)            
                fishRotation -= fishAcceleration;
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
}
