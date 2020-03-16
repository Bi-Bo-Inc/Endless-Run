using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmphibianController : MonoBehaviour
{
    private Rigidbody2D rb;

    public bool onGround = false; //на земле (да/нет)
    public Transform groundCheck; //чекер земли
    public float groundRadius = 0.2f; //радиус чека
    public LayerMask isGround; //что является землёй

    [SerializeField]
    private float jumpForce = 10; //сила прыжка
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundRadius, isGround); //на земле = да, если в радиусе чекера находится что-либо

        Movement();
    }

    private void Movement()
    {
        if(Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.AddForce(Vector2.up * jumpForce * 10);
        }
    }
}
