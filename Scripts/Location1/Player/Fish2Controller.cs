using UnityEngine;


public class Fish2Controller : MonoBehaviour
{
    public GameObject PlayerFish;
    private Rigidbody2D rb;
    private FishController fc;
   

    private float swimForce = 0; //начальная скорость
    private float acceleration = 0.3f; //ускорение
    private float maxSwimForce = 6.5f; //максимальная скорость

    private float fishRotation = 0; //начальное положение
    private float fishAcceleration = 1f; //поворот
    private float maxFishRotation = 25f; //максимальный поворот

    //private float secondsToStart = 1.5f;    //время до старта
    //private float startSpeed = 1.9f;    //скорость выплывания рыбы

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = PlayerFish.transform.position;
        fc = PlayerFish.GetComponent<FishController>();
        swimForce = fc.GetSwimForce();

    }

    private void FixedUpdate()
    {


        if (!FishDeath.IsDeath)
            Game();
        
    }

    private void Game()
    {
        Movement(swimForce);
        FishRotation(fishRotation);

        //  ниже изменение ускорения
        if ((Input.GetKey(KeyCode.Space)) || (Input.touchCount > 0 && ((Input.GetTouch(0).phase == TouchPhase.Moved) || (Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Began))))
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

    private void FishRotation(float fishRotation)
    {
        transform.rotation = Quaternion.Euler(0, 0, fishRotation);
    }

    private void Movement(float swimForce)
    {
        rb.velocity = new Vector2(0, swimForce);
    }
}
