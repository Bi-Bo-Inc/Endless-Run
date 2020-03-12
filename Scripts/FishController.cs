using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FishController : MonoBehaviour
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
        if (Input.GetKey(KeyCode.UpArrow))
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);
        }
    }



}