using UnityEngine;
using UnityEngine.SceneManagement;

public class FishController : MonoBehaviour
{
    private Rigidbody2D rb;

<<<<<<< HEAD
    private float acceleration = 0.3f; // ускорение
    private float maxSwimForce = 6.5f; // максимальная скорость
    private float fishRotation = 0;
    public float maxFishRotation = 17f;
    public float fishAcceleration = 1f;


    private float secondsToStart = 1.5f;
    private float startSpeed = 1.9f;
=======
    private float swimForce = 0; //начальная скорость
    private float acceleration = 0.3f; //ускорение
    private float maxSwimForce = 6.5f; //максимальная скорость

    private float fishRotation = 0; //начальное положение
    public float fishAcceleration = 1f; //поворот
    public float maxFishRotation = 17f; //максимальный поворот

    private float secondsToStart = 1.5f;    //время до старта
    private float startSpeed = 1.9f;    //скорость выплывания рыбы
>>>>>>> master

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate()
    {
<<<<<<< HEAD

=======
>>>>>>> master
        if(secondsToStart > 0)
        {
            secondsToStart -= Time.deltaTime;
            rb.velocity = new Vector2(startSpeed, 0);
<<<<<<< HEAD
            



        }
        else
        {
            
            Game();
        }
       

    }

=======
        }
        else
        { 
            Game();
        }
    }
>>>>>>> master
    
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
                fishRotation += fishAcceleration;
<<<<<<< HEAD

                // transform.rotation = Quaternion.Euler(0, 0, fishRotation);
            }

=======
>>>>>>> master
        }
        else
        {
            if (swimForce > -maxSwimForce)
                swimForce -= acceleration;

            if (fishRotation > -maxFishRotation)            
                fishRotation -= fishAcceleration;
<<<<<<< HEAD

            }

=======
>>>>>>> master
        }
    }
    
    private void FishRotation (float fishRotation)
    {
        transform.rotation = Quaternion.Euler(0, 0, fishRotation);
    }
   
    private void Movement(float swimForce)
    {        
        rb.velocity = new Vector2(0, swimForce);
<<<<<<< HEAD
        
=======
>>>>>>> master
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);
            ScoreScript.scoreValue = 0;
        }
    }
}
